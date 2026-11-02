using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_game
{
    public partial class Ingredients_Window : Form
    {
        protected Dictionary<string, int> ingredientsTray = new Dictionary<string, int>()
        {
            {"Moon Water", 0 },
            {"Sun Bloom", 0 },
            {"Valerian Root", 0 },
            {"Harpy Feather", 0 },
            {"Dragon’s Blood", 0 },
            {"Rosemary", 0 },
            {"Mandrake", 0 },
            {"Hound Fur", 0 },
            {"Pink Salt", 0 },
            {"Rabbit’s Foot", 0 },
            {"Honey", 0 },
            {"Rainbowshroom", 0 },
            {"Wolfsbane", 0 },
            {"Spring Water", 0 }
        };

        private bool isBrewValid = false;
        private int[] potionCount = new int[7];
        private const int maxPotions = 5;

        public Ingredients_Window()
        {
            InitializeComponent();

            cauldron.AllowDrop = true;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void brew_click(object sender, EventArgs e)
        {
            modules.Brew(ref ingredientsTray, ref potionCount);
            isBrewValid = false;
            brewButton.Enabled = false;
            brewButton.Visible = false;
        }

        private void Ingredients_Window_Load(object sender, EventArgs e)
        {
        }

        private void DragonsBlood_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox source = (PictureBox)sender;

            if (source.Tag != null)
            {
                source.DoDragDrop(source.Tag, DragDropEffects.Copy);
            }
        }

        private void cauldron_Click(object sender, EventArgs e)
        {
        }

        private void cauldron_DragDrop(object sender, DragEventArgs e)
        {
            int ingredientID = (int)e.Data.GetData(typeof(int));

            PictureBox destination = (PictureBox)sender;
            destination.Tag = ingredientID;

            modules.AddIngredient(ref ingredientsTray, ingredientID);
            isBrewValid = true;
            brewButton.Enabled = true;
            brewButton.Visible = true;
        }

        private void cauldron_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(int)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DragonsBlood_Click(object sender, EventArgs e)
        {
        }
    }
}