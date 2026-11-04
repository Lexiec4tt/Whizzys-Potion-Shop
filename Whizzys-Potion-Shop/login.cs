using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Economy;

namespace Whizzys_Potion_Shop
{
    public partial class login : Form
    {
        public string PlayerName { get; private set; } = "Player Guest";
        public EconomyManager ecoManager;

        public login(EconomyManager ecoManager)
        {
            InitializeComponent();
            this.ecoManager = ecoManager;
        }

        public login(string playerName)
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (enterName.Text.Length > 10)
            {
                MessageBox.Show("Enter a name shorter than 10 characters!");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(enterName.Text))
                {
                    PlayerName = enterName.Text.Trim();
                }
                else
                {
                    PlayerName = "Player Guest";
                }

                ecoManager.PlayerName = PlayerName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}