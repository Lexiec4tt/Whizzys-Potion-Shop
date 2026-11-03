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
    public partial class RecipeBook : Form
    {
        private int currentPage = 0;

        private Image[] recipePages = new Image[]
        {
            Properties.Resources.healingPage, // p0
            Properties.Resources.staminaPage, // p1
            Properties.Resources.featherfallPage, //p2
            Properties.Resources.amimirPage, // p3
            Properties.Resources.prankPage, // p4
            Properties.Resources.lovePage // p5
        };


        public RecipeBook()
        {
            InitializeComponent();

            turnRight.BackColor = Color.Transparent;
            turnLeft.BackColor = Color.Transparent;
        }

        private void RecipeBook_Load(object sender, EventArgs e)
        {
            currentPage = 0;
            PageDisplay();
        }

        private void PageDisplay()
        {
            pictureBox1.Image = recipePages[currentPage];

            turnLeft.Enabled = (currentPage > 0);
            turnRight.Enabled = (currentPage < recipePages.Length - 1);
        }

        private void turnRight_Click(object sender, EventArgs e)
        {
            int nextPageIndex = currentPage + 1;

            if (nextPageIndex < recipePages.Length)
            {
                currentPage = nextPageIndex;
                PageDisplay();
            }

            //something checker to see if player unlocked recipe already
        }

        private void turnLeft_Click(object sender, EventArgs e)
        {
            int prevPageIndex = currentPage - 1;

            if (prevPageIndex >= 0)
            {
                currentPage = prevPageIndex;
                PageDisplay();
            }
        }
    }
}
