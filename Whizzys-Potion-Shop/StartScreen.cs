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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();

            menuBtn.BackColor = Color.Transparent;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            using (pauseMenu pauseOverlay = new pauseMenu())
            {
                DialogResult result = pauseOverlay.ShowDialog(this);

                if (result == DialogResult.Abort)
                {

                    mainMenu menu = new mainMenu();
                    menu.Show();
                    this.Close();
                }
            }
        }
    }
}
