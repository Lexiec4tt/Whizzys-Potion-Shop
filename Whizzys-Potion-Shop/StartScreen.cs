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
        private Queue<string> dialogueQueue = new Queue<string>();
        List<int> unlockedPotions = new List<int>{ 1, 2, 3 };//placeholder for unlocked potions, will be replaced with actual data from the game state
        private bool customerLeaving = false;
        private bool orderAccepted = false;
        private Potion potion;
        public StartScreen()
        {
            InitializeComponent();

            menuBtn.BackColor = Color.Transparent;
            acceptBtn.Hide();
            declineBtn.Hide();
            dialogueBox1.HideMessage();
        }

        public void GetPotion(Potion potion)
        {
            this.potion = potion;
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
                station = new BrewingStation(this);
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
    }
}
