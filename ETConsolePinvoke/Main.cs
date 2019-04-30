using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETConsolePinvoke
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private string ListToText(List<string> list)
        {
            return String.Join(Environment.NewLine, list);
        }

        private void RefreshConsole()
        {
            List<string> output = ETConsoleHandler.ConsoleToList(radioChat.Checked);
            txtConsole.Text = ListToText(output);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ChatRefresh_Tick(object sender, EventArgs e)
        {
            RefreshConsole();
        }

        private void radioChat_CheckedChanged(object sender, EventArgs e)
        {
            if(radioChat.Checked)
                groupConsole.Text = "Console - Chat";
            RefreshConsole();
        }

        private void radioRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRaw.Checked)
                groupConsole.Text = "Console - Raw";
            RefreshConsole();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            ETConsoleHandler.SendToConsole(cmbCmd.Text.ToLower() == "say", txtCommand.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if(cmbCmd.Text.ToLower() == "say")
            {
                MessageBox.Show("Can't use [GET] with a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<string> output = ETConsoleHandler.ConsoleGet(txtCommand.Text);
            GetOutputWindow getWindow = new GetOutputWindow(ListToText(output));
            getWindow.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferenceWindow prefWin = new PreferenceWindow();
            prefWin.Show();
        }
    }
}
