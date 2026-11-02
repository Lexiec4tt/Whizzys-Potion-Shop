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
    public partial class mainMenu : Form
    {

        private string enteredName;

        public mainMenu()
        {
            InitializeComponent();

            start.FlatStyle = FlatStyle.Flat;
            start.FlatAppearance.BorderSize = 0;
            start.BackColor = Color.Transparent;

            saves.FlatStyle = FlatStyle.Flat;
            saves.FlatAppearance.BorderSize = 0;
            saves.BackColor = Color.Transparent;

            settings.FlatStyle = FlatStyle.Flat;
            settings.FlatAppearance.BorderSize = 0;
            settings.BackColor = Color.Transparent;

            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.FlatAppearance.BorderSize = 0;
            exitbtn.BackColor = Color.Transparent;
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            using (settings settingsModal = new settings())
            {
                settingsModal.ShowDialog(this);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saves_Click(object sender, EventArgs e)
        {
            savefiles saves = new savefiles();
            this.Hide();
            saves.ShowDialog();
            this.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            using (login nameModal = new login())
            {
                if (nameModal.ShowDialog(this) == DialogResult.OK)
                {

                    string enteredName = nameModal.PlayerName;

                    StartScreen gameScreen = new StartScreen();
                    gameScreen.Show();
                    this.Hide();
                }
            }
        }

        public mainMenu(string playerName)
        {
            InitializeComponent();
            enteredName = playerName;

            this.Text = $"Potion Shop - Welcome, {enteredName}";
        }

        private void OpenPauseMenu()
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
