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
using Economy;

namespace Whizzys_Potion_Shop
{
    public partial class StartScreen : Form
    {
        private EconomyManager economyManager = new EconomyManager();
        private GameTime gameTime = new GameTime();
        private DayManager dayManager = new DayManager();
        private OrderManager orderManager = new OrderManager();
        private Queue<string> dialogueQueue = new Queue<string>();
        private List<int> unlockedPotions;//placeholder for unlocked potions, will be replaced with actual data from the game state
        private bool customerLeaving = false;
        private bool orderAccepted = false;
        private bool dialogueWasRunning;
        private bool arrivalWasRunning;
        private Potion potion;

        public StartScreen()
        {
            InitializeComponent();

            menuBtn.BackColor = Color.Transparent;
            acceptBtn.Hide();
            declineBtn.Hide();
            dialogueBox1.HideMessage();
            topHUD1.UpdateGold(economyManager.PlayerBalance.Balance);

            //TEMPORARY: MUST BE IMPLEMENTED THROUGH SAVE FILES IN MAIN MENU
            if (!economyManager.UnlockedPotions.Unlocked.Any())
            {
                economyManager.UnlockedPotions.AddStarter(1);
                economyManager.UnlockedPotions.AddStarter(2);
                economyManager.UnlockedPotions.AddStarter(3);
                unlockedPotions = economyManager.UnlockedPotions.Unlocked.ToList();
            }
        }

        public void GetPotion(Potion potion)
        {
            this.potion = potion;
            selectedPotionBox.Image = potion.potionImage;
            if (orderManager.CurrentCustomer != null && orderAccepted)
            {
                serveBtn.Visible = true;
            }
            else
            {
                serveBtn.Visible = false;
            }
            selectedPotionBox.Visible = true;
            AdvanceGameTime(GameTime.CollectPotionMinutes);
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
                characterBox.Image = Properties.Resources.Wizard_Talk;
            }
            else if (customer is Apprentice)
            {
                characterBox.Image = Properties.Resources.Apprentice_Talk;
            }
            else if (customer is Adventurer)
            {
                characterBox.Image = Properties.Resources.Adventurer_Talk;
            }
        }

        private void CustomerNormalSprite(Customer customer)
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

        private void hideBtns()
        {
            acceptBtn.Hide();
            declineBtn.Hide();
        }

        private void showBtns()
        {
            acceptBtn.Show();
            declineBtn.Show();
        }

        private void GenerateNextCustomer()
        {
            hideBtns();

            if (!dayManager.CanGenerateCustomer)
                return;

            orderAccepted = false;
            customerLeaving = false;

            unlockedPotions = economyManager.UnlockedPotions.Unlocked.ToList();
            orderManager.GenerateCustomerOrder(unlockedPotions);

            UpdateCustomerSprite(orderManager.CurrentCustomer);

            // Display the order details in the UI
            ShowCustomerDialogue();
        }

        private void ShowCustomerDialogue()
        {
            DialogueTimer.Stop();

            Customer customer = orderManager.CurrentCustomer;

            dialogueQueue.Clear();
            UpdateCustomerSprite(customer);
            dialogueQueue.Enqueue(customer.Greet());
            dialogueQueue.Enqueue(customer.PlaceOrderDialogue(orderManager.CurrentOrder));

            dialogueBox1.ShowMessage(dialogueQueue.Dequeue());

            DialogueTimer.Start();
        }

        private void HandleCustomerDeparture()
        {
            AdvanceGameTime(GameTime.CustomerLeaveMinutes);

            Customer departingCustomer = orderManager.CurrentCustomer;

            if (departingCustomer != null && orderAccepted)
            {
                int rating = CalculateCustomerRating(departingCustomer);
                dayManager.RecordRating(rating);
            }

            dayManager.CustomerLeft();
            orderManager.ClearOrder();
            characterBox.Image = null;

            if (dayManager.IsDayComplete)
            {
                DaySummary summaryData = economyManager.EndDay();
                summary summaryForm = new summary(summaryData, dayManager.AverageRating);
                summaryForm.ShowDialog();

                gameTime.NextDay();
                UpdateHUDTime();

                dayManager.ResetDay();
                customerArriveTimer.Start();
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

        private void PauseGame()
        {
            dialogueWasRunning = DialogueTimer.Enabled;
            arrivalWasRunning = customerArriveTimer.Enabled;

            DialogueTimer.Stop();
            customerArriveTimer.Stop();
        }

        private void ResumeGame()
        {
            if (dialogueWasRunning)
                DialogueTimer.Start();

            if (arrivalWasRunning)
                customerArriveTimer.Start();
        }

        private int CalculateCustomerRating(Customer customer)
        {
            double patiencePercent =
                (double)customer.Patience / customer.MaxPatience * 100;

            if (patiencePercent >= 80) return 5;
            if (patiencePercent >= 60) return 4;
            if (patiencePercent >= 40) return 3;
            if (patiencePercent >= 20) return 2;

            return 1;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            using (pauseMenu pauseOverlay = new pauseMenu())
            {
                PauseGame();
                DialogResult result = pauseOverlay.ShowDialog(this);

                if (result == DialogResult.Abort)
                {
                    mainMenu menu = new mainMenu();
                    menu.Show();
                    this.Close();
                }

                ResumeGame();
            }
        }

        private void toBrewBtn_Click(object sender, EventArgs e)
        {
            BrewingStation station = Application.OpenForms
                .OfType<BrewingStation>()
                .FirstOrDefault();

            if (station == null)
            {
                station = new BrewingStation(this, economyManager, gameTime);
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

        private void toUpgradeBtn_Click(object sender, EventArgs e)
        {
            UpgradeStore store = Application.OpenForms
                .OfType<UpgradeStore>()
                .FirstOrDefault();

            if (store == null)
            {
                store = new UpgradeStore();
                store.Show();
                this.Hide();
            }
            else
            {
                store.Show();
                store.BringToFront();
                store.Activate();
                this.Hide();
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

        private void DialogueTimer_Tick(object sender, EventArgs e)
        {
            if (dialogueQueue.Count > 0)
            {
                dialogueBox1.ShowMessage(dialogueQueue.Dequeue());
            }
            else
            {
                DialogueTimer.Stop();
                dialogueBox1.HideMessage();
                if (customerLeaving)
                {
                    customerLeaving = false;
                    HandleCustomerDeparture();
                }
                else if (orderManager.CurrentCustomer != null && !orderAccepted)
                {
                    showBtns();
                    CustomerNormalSprite(orderManager.CurrentCustomer);
                }
                else if (orderManager.CurrentCustomer != null)
                {
                    CustomerNormalSprite(orderManager.CurrentCustomer);
                }
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (orderManager.CurrentCustomer == null)
                return;
            hideBtns();
            orderAccepted = true;
            AdvanceGameTime(GameTime.AcceptOrderMinutes);

            DialogueTimer.Stop();
            dialogueQueue.Clear();
            UpdateCustomerSprite(orderManager.CurrentCustomer);
            dialogueBox1.ShowMessage(
                orderManager.CurrentCustomer.ReactToAcceptance()
            );

            DialogueTimer.Start();
            CustomerNormalSprite(orderManager.CurrentCustomer);
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            if (orderManager.CurrentCustomer == null)
                return;

            hideBtns();
            AdvanceGameTime(GameTime.RefuseOrderMinutes);

            dialogueQueue.Clear();
            dialogueQueue.Enqueue(orderManager.CurrentCustomer.ReactToRefusal());

            DialogueTimer.Stop();
            dialogueBox1.ShowMessage(dialogueQueue.Dequeue());
            DialogueTimer.Start();

            customerLeaving = true;
        }

        private void serveBtn_Click(object sender, EventArgs e)
        {
            if (potion == null)
                return;
            int basePayment = 0;

            switch (potion.potionID)
            {
                case 1:
                    basePayment = 150;
                    break;

                case 2:
                    basePayment = 185;
                    break;

                case 3:
                    basePayment = 200;
                    break;

                case 4:
                    basePayment = 225;
                    break;

                case 5:
                    basePayment = 200;
                    break;

                case 6:
                    basePayment = 300;
                    break;
            }

            bool accepted = orderManager.DeliverPotion(potion, economyManager, basePayment);
            topHUD1.UpdateGold(economyManager.PlayerBalance.Balance);

            selectedPotionBox.Image = null;
            selectedPotionBox.Visible = false;
            potion = null;
            serveBtn.Visible = false;

            if (accepted)
            {
                dialogueQueue.Enqueue(orderManager.CurrentCustomer.ReactToCorrectOrder());
                AdvanceGameTime(GameTime.ServeOrderMinutes);

                if (orderManager.IsOrderComplete())
                {
                    dialogueQueue.Enqueue(orderManager.CurrentCustomer.CompletedOrder());
                    dialogueQueue.Enqueue(orderManager.CurrentCustomer.LeaveShop());
                    customerLeaving = true;
                    // Customer's order is complete
                }
            }
            else
            {
                dialogueQueue.Enqueue(orderManager.CurrentCustomer.ReactToWrongOrder());
                AdvanceGameTime(GameTime.ServeOrderMinutes);
                if (orderManager.CurrentCustomer.Patience <= 0)
                {
                    dialogueQueue.Enqueue(orderManager.CurrentCustomer.ReactToPatienceDepletion());
                    dialogueQueue.Enqueue(orderManager.CurrentCustomer.LeaveShop());
                    customerLeaving = true;
                    // Customer leaves due to impatience
                }
            }
            UpdateCustomerSprite(orderManager.CurrentCustomer);
            dialogueBox1.ShowMessage(dialogueQueue.Dequeue());
            DialogueTimer.Start();
        }

        private void topHUD1_Load(object sender, EventArgs e)
        {
        }
    }
}