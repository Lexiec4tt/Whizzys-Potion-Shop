using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whizzys_Potion_Shop
{
    public partial class BrewingStation : Form
    {
        public BrewingStation()
        {
            InitializeComponent();
        }

        private void BrewingStation_Load(object sender, EventArgs e)
        {

        }
        private void TransparentPictures(Control Parent) 
        {
            foreach (Control control in Parent.Controls)
            {
                if (control is PictureBox pictureBox) 
                {
                    pictureBox.BackColor = Color.Transparent;
                }
            }
        }

        private void TransparentLabels(Control Parent)
        {
            foreach (Control control in Parent.Controls)
            {
                if (control is Label label)
                {
                    label.BackColor = Color.Transparent;
                }
            }
        }

        private void pinkSaltCounter_Click(object sender, EventArgs e)
        {

        }

        //
    }
}
