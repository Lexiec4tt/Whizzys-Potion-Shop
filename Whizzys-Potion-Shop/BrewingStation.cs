using Economy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whizzys_Potion_Shop.Properties;

namespace Whizzys_Potion_Shop
{
    public partial class BrewingStation : Form
    {
        public Dictionary<string, int> cauldronIngredCount = new Dictionary<string, int>()
        {
            {"Moon Water", 0 },
            {"Sun Bloom", 0 },
            {"Valerian Root", 0 },
            {"Harpy Feather", 0 },
            {"Dragon's Blood", 0 },
            {"Rosemary", 0 },
            {"Mandrake", 0 },
            {"Hound Fur", 0 },
            {"Pink Salt", 0 },
            {"Rabbit's Foot", 0 },
            {"Honey", 0 },
            {"Rainbowshroom", 0 },
            {"Wolfsbane", 0 },
            {"Spring Water", 0 }
        };

        private EconomyManager economyManager;
        private GameTime gameTime;
        private int[] potionCount = new int[7];
        private int cauldronState = 1;

        private double elapsedTime = 0;
        private int warningTime = 0;
        private Potion potionBrewed;

        private PictureBox[] potionInventoryImage = new PictureBox[5];
        private Potion[] potionInventory = new Potion[5];
        private StartScreen startScreen;

        private Ingredients[] ingredients;

        public BrewingStation(StartScreen screen, EconomyManager ecoManager, GameTime gTime)
        {
            InitializeComponent();

            potionInventoryImage = new[]
                        {
                            potionInventory1,
                            potionInventory2,
                            potionInventory3,
                            potionInventory4,
                            potionInventory5
                        };

            ingredients = new Ingredients[]
                {
                    new MoonWater(),
                    new SunBloom(),
                    new ValerianRoot(),
                    new HarpyFeather(),
                    new DragonsBlood(),
                    new Rosemary(),
                    new Mandrake(),
                    new HoundFur(),
                    new PinkSalt(),
                    new RabbitsFoot(),
                    new Honey(),
                    new Rainbowshroom(),
                    new Wolfsbane(),
                    new SpringWater()
                };

            cauldron.AllowDrop = true;
            startScreen = screen;
            economyManager = startScreen.economyManager;
            gameTime = gTime;
            topHUD1.UpdateGold(economyManager.Balance);
            topHUD1.UpdateTime(
                gameTime.FormattedDay,
                gameTime.FormattedTime
            );

            warningLabel.ForeColor = Color.White;
        }

        private bool warningWasRunning;
        private bool wasBrewing;

        private void PauseGame()
        {
            warningWasRunning = warningTimer.Enabled;
            wasBrewing = brewTimer.Enabled;

            warningTimer.Stop();
            brewTimer.Stop();
        }

        private void ResumeGame()
        {
            if (warningWasRunning)
                warningTimer.Start();

            if (wasBrewing)
                brewTimer.Start();
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

        private void pinkSalt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void cauldron_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(int)))
            {
                e.Effect = DragDropEffects.Copy;
                cauldron.Image = Properties.Resources.yellow;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void cauldron_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(int)))
            {
                int ingredientTag = (int)e.Data.GetData(typeof(int));
                cauldron.Image = Properties.Resources.emptycldrn;

                Ingredients ingredient = ingredients[ingredientTag - 1];

                if (economyManager.CanAfford(ingredient.cost))
                {
                    modules.AddIngredient(cauldronIngredCount, ingredientTag);
                    int newBalance = economyManager.Balance - economyManager.BuyIngredient(ingredient.cost);
                    topHUD1.UpdateGold(newBalance);
                    brewButton.Enabled = true;
                    brewButton.Visible = true;
                }
                else
                {
                    warningLabel.Text = "Insufficient funds!";
                    warningTimer.Start();
                }
            }
        }

        private void Rosemary_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void valRoot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void harpyFeathers_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void rabbitsFoot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void houndFur_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void Wolfsbane_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void Honey_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void DragonBlood_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void MoonWater_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void SpringWater_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void RBShroom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void Mandrake_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void SunBloom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox ingredient = (PictureBox)sender;

                DataObject data = new DataObject();
                data.SetData(typeof(int), Convert.ToInt32(ingredient.Tag));

                ingredient.DoDragDrop(data, DragDropEffects.Copy);
            }
        }

        private void brewButton_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void brewButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                potionBrewed = modules.Brew(cauldronIngredCount);
                brewButton.Enabled = false;
                brewButton.Visible = false;
                elapsedTime = 0;
                brewTimer.Start();
            }
        }

        private void brewButton_Click(object sender, EventArgs e)
        {
        }

        private void brewTimer_Tick(object sender, EventArgs e)
        {
            cauldron.Enabled = false;
            // Cauldron mixing animation
            if (cauldronState == 1)
            {
                cauldron.Image = Properties.Resources.cldn;
                cauldronState = 2;
            }
            else
            {
                cauldron.Image = Properties.Resources.cldn1;
                cauldronState = 1;
            }

            elapsedTime += 0.5;

            if (elapsedTime >= potionBrewed.brewingTime)
            {
                brewTimer.Stop();

                potionCollect.Image = potionBrewed.potionImage;
                cauldron.Enabled = false;
                potionCollect.Enabled = true;
                potionCollect.Visible = true;
                cauldron.Image = potionBrewed.cauldronImage;
                elapsedTime = 0;
            }
        }

        private void cauldron_Click(object sender, EventArgs e)
        {
        }

        private void potionCollect_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                modules.collectPotion(potionBrewed, potionCount);
                cauldron.Image = Properties.Resources.emptycldrn;
                try
                {
                    int freePotionIndex = 0;
                    foreach (Potion potion in potionInventory)
                    {
                        if (potion == null)
                        {
                            break;
                        }
                        freePotionIndex++;
                    }
                    potionInventoryImage[freePotionIndex].Image = potionCollect.Image;
                    potionInventory[freePotionIndex] = potionBrewed;
                    potionCollect.Enabled = false;
                    potionCollect.Visible = false;
                    cauldron.Enabled = true;
                }
                catch (IndexOutOfRangeException)
                {
                    if (warningTimer.Enabled)
                    {
                        warningTime = 0;
                        warningTimer.Stop(); // Clears the warning timer before starting another timer
                    }

                    warningLabel.Text = "Max of 5 Potions only!";
                    warningTimer.Start();
                }
            }
        }

        private void cauldron_DragOver(object sender, DragEventArgs e)
        {
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void serveButton_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void cauldron_DragLeave(object sender, EventArgs e)
        {
            cauldron.Image = Properties.Resources.emptycldrn;
        }

        private void warningTimer_Tick(object sender, EventArgs e)
        {
            warningTime++;

            if (warningTime < 3)
            {
                warningTimer.Stop();
                warningTime = 0;
                warningLabel.Text = "";
            }
        }

        private void potionInventory1_MouseDown(object sender, MouseEventArgs e)
        {
            int tagInt = Convert.ToInt32(((Control)sender).Tag) - 1;
            if (e.Button == MouseButtons.Left)
            {
                startScreen.GetPotion(potionInventory[tagInt]);
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
                startScreen.Show();
                startScreen.BringToFront();
                startScreen.Activate();
                this.Hide();
            }
            else if (e.Button == MouseButtons.Right)
            {
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
            }
        }

        private void potionInventory3_MouseDown(object sender, MouseEventArgs e)
        {
            int tagInt = Convert.ToInt32(((Control)sender).Tag) - 1;
            if (e.Button == MouseButtons.Left)
            {
                startScreen.GetPotion(potionInventory[tagInt]);
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
                startScreen.Show();
                startScreen.BringToFront();
                startScreen.Activate();
                this.Hide();
            }
            else if (e.Button == MouseButtons.Right)
            {
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
            }
        }

        private void potionInventory2_MouseDown(object sender, MouseEventArgs e)
        {
            int tagInt = Convert.ToInt32(((Control)sender).Tag) - 1;
            if (e.Button == MouseButtons.Left)
            {
                startScreen.GetPotion(potionInventory[tagInt]);
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
                startScreen.Show();
                startScreen.BringToFront();
                startScreen.Activate();
                this.Hide();
            }
            else if (e.Button == MouseButtons.Right)
            {
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
            }
        }

        private void potionInventory4_MouseDown(object sender, MouseEventArgs e)
        {
            int tagInt = Convert.ToInt32(((Control)sender).Tag) - 1;
            if (e.Button == MouseButtons.Left)
            {
                startScreen.GetPotion(potionInventory[tagInt]);
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
                startScreen.Show();
                startScreen.BringToFront();
                startScreen.Activate();
                this.Hide();
            }
            else if (e.Button == MouseButtons.Right)
            {
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
            }
        }

        private void potionInventory5_MouseDown(object sender, MouseEventArgs e)
        {
            int tagInt = Convert.ToInt32(((Control)sender).Tag) - 1;
            if (e.Button == MouseButtons.Left)
            {
                startScreen.GetPotion(potionInventory[tagInt]);
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
                startScreen.Show();
                startScreen.BringToFront();
                startScreen.Activate();
                this.Hide();
            }
            else if (e.Button == MouseButtons.Right)
            {
                modules.disposePotion(potionInventoryImage, potionInventory, tagInt);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void rbshroomCounter_Click(object sender, EventArgs e)
        {
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

        private void cashierButton_Click(object sender, EventArgs e)
        {
            StartScreen station = Application.OpenForms
                .OfType<StartScreen>()
                .FirstOrDefault();

            if (station == null)
            {
                station = new StartScreen();
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
    }
}