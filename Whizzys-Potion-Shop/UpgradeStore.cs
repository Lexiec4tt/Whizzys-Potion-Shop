using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whizzys_Potion_Shop;
using Economy;
using Economy.Upgrades;

namespace Whizzy_Potion_Shop
{
    public partial class UpgradeStore : Form
    {
        private EconomyManager economyManager;
        private StartScreen startScreen;

        public UpgradeStore(StartScreen screen, EconomyManager ecoManager)
        {
            InitializeComponent();
            startScreen = screen;
            economyManager = ecoManager;
            incense.BackColor = Color.Transparent;
            cauldronUpgrade.BackColor = Color.Transparent;
            stirringUpd.BackColor = Color.Transparent;
            wilkUpgrade.BackColor = Color.Transparent;
        }

        private void UpgradeStore_Load(object sender, EventArgs e)
        {
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            using (pauseMenu pauseOverlay = new pauseMenu(startScreen, economyManager))
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

        private void cashierButton_Click(object sender, EventArgs e)
        {
            StartScreen station = Application.OpenForms
                .OfType<StartScreen>()
                .FirstOrDefault();

            if (station == null)
            {
                station = new StartScreen(economyManager);
                station.Show();
                this.Hide();
            }
            else
            {
                station.Show();
                station.BringToFront();
                station.Activate();
                this.Hide();
            }
        }

        private void incense_Click(object sender, EventArgs e)
        {
            economyManager.BuyUpgrade(UpgradeType.Incense);
        }

        private void stirringUpd_Click(object sender, EventArgs e)
        {
            economyManager.BuyUpgrade(UpgradeType.StirringSpoon);
        }

        private void cauldronUpgrade_Click(object sender, EventArgs e)
        {
            economyManager.BuyUpgrade(UpgradeType.Cauldron);
        }

        private void wilkUpgrade_Click(object sender, EventArgs e)
        {
            economyManager.BuyUpgrade(UpgradeType.Kindling);
        }
    }
}