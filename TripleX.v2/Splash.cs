using CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TripleX.v2
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + " %";

            if(circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form form = new MainForm();
                form.Show();
                this.Hide();
            }
        }

        private void Splash_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedForm(this, 8, e.Graphics, Color.Empty, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "http://www.google.com",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
