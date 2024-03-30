using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StewaPC
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            pgsBar.Value = startpoint;
            if(pgsBar.Value == 100)
            {
                pgsBar.Value = 0;
                timer1.Stop();
                loginForm frmL = new loginForm();
                this.Hide();
                frmL.ShowDialog();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
