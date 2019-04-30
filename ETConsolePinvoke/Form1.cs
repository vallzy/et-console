using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ETConsolePinvoke
{
    public partial class Splash1 : Form
    {
        public Splash1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateMain()
        {
            Main mainForm = new Main();
            mainForm.ShowDialog();
        }

        private void FindET_Tick(object sender, EventArgs e)
        {
            if(ETConsoleHandler.FindConsole())
            {
                lblFound.ForeColor = Color.LimeGreen;
                lblFound.Text = "Found";
                findWin.Start();
                findET.Stop();
            }
        }

        private void FindWin_Tick(object sender, EventArgs e)
        {
            if(ETConsoleHandler.GetParent() != IntPtr.Zero)
            {
                lblConFound.ForeColor = Color.LimeGreen;
                lblConFound.Text = "Found";
                findWin.Stop();
                this.Hide();
            }
        }

        private void lblConFound_TextChanged(object sender, EventArgs e)
        {
            CreateMain();
        }

        private void chatRefresh_Tick(object sender, EventArgs e)
        {

        }
    }
}
