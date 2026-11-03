using System;
using System.Collections.Generic;
using System.Text;

// used to calculate the entire day and return data

namespace Economy
{
    public class DaySummary
    {
        public int Day { get; }
        public int Earnings { get; }
        public int Expenses {  get; }
        public int Profit => Earnings - Expenses;
        public int CustomersServed { get; }
        public List<int> NewUnlocks { get; } = new();

        public DaySummary(int day, int earnings, int expenses, int customersServed)
        {
            Day = day;
            Earnings = earnings;
            Expenses = expenses;
            CustomersServed = customersServed;
    }

    }
}
