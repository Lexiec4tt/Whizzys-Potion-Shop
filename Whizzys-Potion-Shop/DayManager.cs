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
        private int _TotalRating;
        private int _TotalCustomers;

        public int CustomersLeft { get; private set; }

        public bool IsDayComplete =>
            CustomersLeft >= DailyCustomerLimit;

        public bool CanGenerateCustomer =>
            CustomersLeft < DailyCustomerLimit;

        public void CustomerLeft()
        {
            if (CustomersLeft < DailyCustomerLimit)
            {
                CustomersLeft++;
            }
        }

        public void RecordRating(int rating)
        {
            _TotalRating += rating;
            _TotalCustomers++;
        }

        public void ResetDay()
        {
            CustomersLeft = 0;
            _TotalCustomers = 0;
            _TotalRating = 0;
        }

        public double AverageRating =>_TotalCustomers == 0 ? 0 : (double)_TotalRating / _TotalCustomers;

    }
}

