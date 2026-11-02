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
    public partial class topHUD : UserControl
    {
        public topHUD()
        {
            InitializeComponent();

            this.BackColor = Color.Transparent;
        }

        public void UpdateGold(int newGoldAmount)
        {
            coins.Text = $"{newGoldAmount} Gold";
        }

        public void UpdateTime(string timeString, string dayString)
        {
            time.Text = $"{timeString}";
            day.Text = $"{dayString}";
        }
    }
}
