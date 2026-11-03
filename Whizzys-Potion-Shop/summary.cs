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

namespace Whizzys_Potion_Shop
{
    public partial class summary : Form
    {
        public DaySummary DayData { get; set; }
        public double AverageRating { get; set; }
        public summary(DaySummary dayData, double averageRating)
        {
            InitializeComponent();
            DayData = dayData;
            AverageRating = averageRating;
            DisplayDaySummary();
        }

        private void DisplayDaySummary()
        {
            revenueCount.Text = DayData.Earnings.ToString();
            customersCount.Text = DayData.CustomersServed.ToString();
            dayCounter.Text = "Day " + DayData.Day;
            label1.Text = DayData.Profit.ToString();
            if(AverageRating != 0)
            {
                ratingCount.Text = AverageRating.ToString("0.0") + " / 5";
            }
            else
            {
                ratingCount.Text = "N/A";
            }
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
