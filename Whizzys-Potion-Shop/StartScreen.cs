using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whizzy_Potion_Shop;

namespace Whizzys_Potion_Shop
{
    public partial class StartScreen : Form
    {
        private GameTime gameTime = new GameTime();
        private DayManager dayManager = new DayManager();
        private OrderManager orderManager = new OrderManager();
        public StartScreen()
        {
            InitializeComponent();

            menuBtn.BackColor = Color.Transparent;
        }
        private void UpdateHUDTime()
        {
            topHUD1.UpdateTime(
                gameTime.FormattedDay,
                gameTime.FormattedTime
            );
        }

        private void AdvanceGameTime(int minutes)
        {
            gameTime.AdvanceTime(minutes);
            UpdateHUDTime();
        }

        private void UpdateCustomerSprite(Customer customer)
        {
            if (customer is Wizard)
            {
                characterBox.Image = Properties.Resources.Wizard;
            }
            else if (customer is Apprentice)
            {
                characterBox.Image = Properties.Resources.Apprentice;
            }
            else if (customer is Adventurer)
            {
                characterBox.Image = Properties.Resources.Adventurer;
            }
        }

        private void GenerateNextCustomer()
        {
            if (!dayManager.CanGenerateCustomer)
                return;

            orderManager.GenerateCustomerOrder(unlockedPotions);

            UpdateCustomerSprite(orderManager.CurrentCustomer);
        }

        private void HandleCustomerDeparture()
        {
            AdvanceGameTime(GameTime.CustomerLeaveMinutes);
            dayManager.CustomerLeft();
            orderManager.ClearOrder();
            characterBox.Image = null;

            if (dayManager.IsDayComplete)
            {
                // End-of-day sequence
            }
            else
            {
                if (dayManager.CanGenerateCustomer)
                {
                    customerArriveTimer.Start();
                }
            }
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

        private void toBrewBtn_Click(object sender, EventArgs e)
        {
            BrewingStation station = Application.OpenForms
                .OfType<BrewingStation>()
                .FirstOrDefault();

            if (station == null)
            {
                station = new BrewingStation();
                station.Show();
            }
            else
            {
                station.Show();
                station.BringToFront();
            }
        }

        private void toUpgradeBtn_Click(object sender, EventArgs e)
        {
            UpgradeStore store = Application.OpenForms
                .OfType<UpgradeStore>()
                .FirstOrDefault();

            if (store == null)
            {
                store = new UpgradeStore();
                store.Show();
            }
            else
            {
                store.Show();
                store.BringToFront();
            }
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            UpdateHUDTime();
            customerArriveTimer.Start();
        }

        private void customerArriveTimer_Tick(object sender, EventArgs e)
        {
            customerArriveTimer.Stop();
            GenerateNextCustomer();
        }
    }
}
