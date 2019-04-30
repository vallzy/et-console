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
    public partial class GetOutputWindow : Form
    {
        public GetOutputWindow(string output)
        {
            InitializeComponent();
            richTextBox1.Text = output;
        }

        private void GetOutputWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
