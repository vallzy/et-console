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
    public partial class PreferenceWindow : Form
    {
        public class Preferences
        {
            public int WaitTime { get; set; }
        }


        private Preferences pref;
        public PreferenceWindow()
        {
            InitializeComponent();
            pref = new Preferences();
        }

        private Preferences GetPref()
        {
            Preferences _pref = new Preferences
            {
                WaitTime = 700
            };
            return _pref;
        }

        private void PreferenceWindow_Load(object sender, EventArgs e)
        {
            pref = GetPref();
            float x = (float)pref.WaitTime / 1000;
            lblWait.Text = x.ToString() + " ms";
            trkWait.Value = (int)pref.WaitTime / 100;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float x = (float)trkWait.Value / 10;
            lblWait.Text = x.ToString() + " ms";
        }
    }
}
