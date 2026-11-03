using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whizzys_Potion_Shop
{
    internal class DayManager
    {
        public const int DailyCustomerLimit = 5;

        public int CustomersLeft { get; private set; }

        public bool IsDayComplete =>
            CustomersLeft >= DailyCustomerLimit;

        public bool CanGenerateCustomer =>
            CustomersLeft < DailyCustomerLimit;

        public void CustomerLeft()
        {
            if (CustomersLeft < DailyCustomerLimit)
                CustomersLeft++;
        }

        public void ResetDay()
        {
            CustomersLeft = 0;
        }
    }
}

