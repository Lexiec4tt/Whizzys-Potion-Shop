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
    public partial class savefiles : Form
    {

        public savefiles()
        {
            InitializeComponent();

            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            menu.Show();
            this.Hide();
        }

        //private void LoadSaveFile() 
        //{
            //var allSaves = //saveMethod here

           //foreach (var save in allSaves) 
            //{
               //ListViewItem item = new ListViewItem(save.PlayerName);

                //item.SubItems.Add(save.DayNumber.ToString());
                //item.SubItems.Add(save.GoldAmount);
                //item.Tag = save;

                //saveList.Items.Add(item);
            //}
        //}
    }
}
