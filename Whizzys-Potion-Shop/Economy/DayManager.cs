using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Economy;

namespace Economy
{
    public class DayManager
    {
        public int CurrentDay {  get; private set; }

        private int _Earnings;
        private int _Expenses;
        private int _Customers;


        public void RecordEarning(int amount) { if (amount > 0) _Earnings += amount; }
        public void RecordExpenses(int amount) { if (amount > 0) _Expenses += amount; }
        public void RecordCustomer() => _Customers ++;
        public DaySummary EndDay()
        {
            // record present day
            DaySummary Summary = new DaySummary(CurrentDay, _Earnings, _Expenses, _Customers);
            CurrentDay++; // add a new day
            _Earnings = _Expenses = _Customers = 0; // reset readings
            return Summary;

        }

        // for loading files
        public void SetDay(int day)
        {
            CurrentDay = Math.Max(1, day);
        }
        
    }
}
