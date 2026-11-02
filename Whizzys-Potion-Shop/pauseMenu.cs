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
    public partial class pauseMenu : Form
    {
        public pauseMenu()
        {
            InitializeComponent();

            pauseIcon.BackColor = Color.Transparent;
            resume.BackColor = Color.Transparent;
            settingsBtn.BackColor = Color.Transparent;
            saveExit.BackColor = Color.Transparent;
            toMenu.BackColor = Color.Transparent;
        }

        private void resume_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            using (settings settingsOverlay = new settings())
            {
                settingsOverlay.ShowDialog(this);
            }
        }

        private void toMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void saveExit_Click(object sender, EventArgs e)
        {
            //save game data method here

            Application.Exit();
        }

    }
}
