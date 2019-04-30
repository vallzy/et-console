using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETConsolePinvoke
{
    public class Command
    {
        public string Cmd { get; set; }
        public List<string> Before { get; set; }
        public List<string> After { get; set; }
    }

    public static class ETConsoleHandler
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string className, string lpszWindow);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool PostMessage(int hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern Int32 SendMessage(int hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern Int32 SendMessage(int hWnd, int Msg, int wParam, StringBuilder lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern int SendMessage(int hWnd, uint msg, int wParam, string lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern long GetClassName(IntPtr hwnd, StringBuilder lpClassName, long nMaxCount);

        private const int WM_SETTEXT        = 0x000C;
        private const int WM_GETTEXT        = 0x000D;
        private const int WM_GETTEXTLENGTH  = 0x000E;
        private const int WM_KEYDOWN        = 0x0290;

        public static bool FindConsole()
        {
            Process[] etProcesses = Process.GetProcessesByName("et");
            return etProcesses.Length > 0;
        }

        public static IntPtr GetParent()
        {
            return FindWindow(null, "ET Console");
        }

        private static string ConsoleOutput()
        {
            IntPtr parent = GetParent();
            List<IntPtr> children = GetChildren(parent);
            IntPtr Messages = GetMessages(children);
            int txtLength = SendMessage((int)Messages, WM_GETTEXTLENGTH, 0, 0);
            StringBuilder sb = new StringBuilder(txtLength + 1);
            SendMessage((int)Messages, WM_GETTEXT, sb.Capacity, sb);
            return sb.ToString();;
        }
        
        public static void SendToConsole(bool isMessage, string command)
        {
            string msg = command;
            if (isMessage)
                msg = "say " + command;
            IntPtr parent = GetParent();
            List<IntPtr> children = GetChildren(parent);
            IntPtr Textb = GetTextB(children);
            SendMessage((int)Textb, WM_SETTEXT, 0, msg);
            PostMessage((int)Textb, WM_KEYDOWN, (int)Keys.Enter, 0);
        }

        private static IntPtr GetTextB(List<IntPtr> children)
        {
            IntPtr textb = IntPtr.Zero;
            foreach (IntPtr child in children)
            {
                int txtLength = SendMessage((int)child, WM_GETTEXTLENGTH, 0, 0);
                StringBuilder sb = new StringBuilder(txtLength + 1);
                SendMessage((int)child, WM_GETTEXT, sb.Capacity, sb);
                string sbs = sb.ToString().ToLower();
                if (sbs == String.Empty)
                    textb = child;
            }
            return textb;
        }

        private static IntPtr GetMessages(List<IntPtr> children)
        {
            IntPtr textb = IntPtr.Zero;
            foreach (IntPtr child in children)
            {
                int txtLength = SendMessage((int)child, WM_GETTEXTLENGTH, 0, 0);
                StringBuilder sb = new StringBuilder(txtLength + 1);
                SendMessage((int)child, WM_GETTEXT, sb.Capacity, sb);
                string sbs = sb.ToString().ToLower().Trim();
                if (sbs != String.Empty)
                    textb = child;
            }
            return textb;
        }

        private static List<IntPtr> GetAllChildrenWindowHandles(IntPtr parent, int max)
        {
            List<IntPtr> result = new List<IntPtr>();
            int count = 0;
            IntPtr prev = IntPtr.Zero;
            IntPtr curr = IntPtr.Zero;
            while (true && count < max)
            {
                curr = FindWindowEx(parent, prev, null, null);
                if (curr == IntPtr.Zero) break;
                result.Add(curr);
                prev = curr;
                ++count;
            }
            return result;
        }

        private static bool RemoveChild(IntPtr child)
        {
            int txtLength = SendMessage((int)child, WM_GETTEXTLENGTH, 0, 0);
            StringBuilder sb = new StringBuilder(txtLength + 1);
            SendMessage((int)child, WM_GETTEXT, sb.Capacity, sb);
            string sbs = sb.ToString().ToLower();
            if (sbs == "quit" || sbs == "clear" || sbs == "copy")
                return true;
            return false;
        }

        private static List<IntPtr> GetChildren(IntPtr parent)
        {
            List<IntPtr> children = GetAllChildrenWindowHandles(parent, 100);
            List<IntPtr> newchildren = new List<IntPtr>();
            foreach (IntPtr child in children)
            {
                if (!RemoveChild(child))
                    newchildren.Add(child);
            }
            return newchildren;
        }

        public static List<string> ConsoleGet(string command)
        {
            //Get Before
            List<string> before = ConsoleToList(false);
            SendToConsole(false, command);
            System.Threading.Thread.Sleep(1000);
            List<string> after = ConsoleToList(false);
            after.RemoveRange(0, before.Count);
            return after;
        }

        public static List<string> ConsoleToList(bool format)
        {
            string output = ConsoleOutput();
            List<string> strList = new List<string>();
            string pattern = @"\[[0-9]{2}:[0-9]{2}:[0-9]{2}].*";
            string txt = ConsoleOutput();
            foreach (string id in txt.Split(new[] { "\r\n" }, StringSplitOptions.None))
            {
                if (format)
                {
                    Match m = Regex.Match(id, pattern, RegexOptions.IgnoreCase);
                    if (m.Success)
                    {
                        string result2 = id;
                        if (result2.Contains("[skipnotify]:"))
                        {
                            int index1 = result2.IndexOf("[skipnotify]:");
                            if (index1 != -1)
                            {
                                result2 = result2.Remove(id.IndexOf("[skipnotify]:"), "[skipnotify]:".Length).TrimStart();
                                if (result2.Trim().Length > 0)
                                    strList.Add(result2);
                            }
                        }
                        else
                        {
                            if (id.Trim().Length > 0)
                                strList.Add(id);
                        }
                    }
                }
                else
                {
                    strList.Add(id);
                }
            }
            return strList;
        }
    }
}
