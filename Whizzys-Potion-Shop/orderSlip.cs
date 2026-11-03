using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class orderSlip : UserControl
    {
        public orderSlip()
        {
            InitializeComponent();

            this.BackColor = Color.Transparent;
        }

        //public void DisplayOrder(List<(thePotionOrdershere?)> activeOrder)
        //{
            //string orderText = "";

            //foreach (var item in activeOrder)
            //{
                //orderText += $"{item.PotionName}  {item.Quantity}\n";
            //}

            //orderList.Text = orderText;
        //}
    }
}
