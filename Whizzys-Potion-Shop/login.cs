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

namespace Whizzys_Potion_Shop
{
    public partial class login : Form
    {
        public string PlayerName { get; private set; } = "Player Guest";

        public login()
        {
            InitializeComponent();
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
            if (!string.IsNullOrWhiteSpace(enterName.Text))
            {
                PlayerName = enterName.Text.Trim();
            }
            else
            {
                PlayerName = "Player Guest";
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
