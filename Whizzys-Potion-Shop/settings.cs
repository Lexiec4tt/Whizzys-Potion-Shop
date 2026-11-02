using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MVpctg.Text = $"{trackBar1.Value}%";
        }

        private void apply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MVpctg_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            MUpctg.Text = $"{trackBar2.Value}%";
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            sfxpctg.Text = $"{trackBar2.Value}%";
        }
    }
}
