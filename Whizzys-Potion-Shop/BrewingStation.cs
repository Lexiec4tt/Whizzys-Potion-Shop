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

        private int[] potionCount = new int[7];

        public BrewingStation()
        {
            InitializeComponent();

            cauldron.AllowDrop = true;
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

                modules.AddIngredient(cauldronIngredCount, ingredientTag);

                brewButton.Enabled = true;
                brewButton.Visible = true;
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
                modules.Brew(cauldronIngredCount, potionCount);
                brewButton.Enabled = false;
                brewButton.Visible = false;
            }
        }
    }
}