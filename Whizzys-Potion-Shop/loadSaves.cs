using Economy;
using Economy.FileHandling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            foreach (SaveData saveData in EconomyManager.GetAllSaves())
            {
                ListViewItem item = new ListViewItem(saveData.PlayerName);

                item.SubItems.Add(saveData.CurrentDay.ToString());
                item.SubItems.Add(saveData.Balance.ToString());
                item.Tag = saveData;

                saveList.Items.Add(item);
            }
        }

        private void saveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EconomyManager loadedEco = new EconomyManager();
            if (saveList.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = saveList.SelectedItems[0];

                string playerName = selectedRow.Text;

                loadedEco.Load(playerName);

                this.DialogResult = DialogResult.OK;

                StartScreen gameScreen = new StartScreen(loadedEco);
                gameScreen.Show();
                this.Close();
            }
        }
    }
}