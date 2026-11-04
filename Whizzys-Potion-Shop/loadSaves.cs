using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Economy;
using Economy.FileHandling;

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

            LoadSaveFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            menu.Show();
            this.Hide();
        }

        private void LoadSaveFile() 
        {
            saveList.Items.Clear();

            foreach(SaveData saveData in EconomyManager.GetAllSaves())
            {
                ListViewItem item = new ListViewItem(saveData.PlayerName);

                item.SubItems.Add(saveData.CurrentDay.ToString());
                item.SubItems.Add(saveData.Balance.ToString());
                item.Tag = saveData;

                saveList.Items.Add(item);
            }
        }
        
    }
}
