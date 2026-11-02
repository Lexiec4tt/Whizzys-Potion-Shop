using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Whizzys_Potion_Shop
{
    public abstract class Customer
    {
        protected static readonly Random _random = new Random();
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Patience { get; set; }
        public bool IsServed { get; set; }
        public List<int> PreferredItems { get; protected set; }
        public bool HasIllIntentions { get; set; } 

        public Customer(int customerID, string customerName)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            IsServed = false;
            HasIllIntentions = SetIllIntentions();
        }

        public int DecreasePatience()
        {
            if (Patience > 0)
            {
                Patience--;
            }
            return Patience;
        }

        protected bool SetIllIntentions()
        {
            return _random.Next(2) == 0; // Randomly set ill intentions to true or false
        }
    }

    public class Wizard : Customer
    {

        public Wizard(int customerID, string customerName) : base(customerID, customerName)
        {
            Patience = 5; // Wizards have a patience level of 5
            PreferredItems = new List<int> { 1, 2, 3 };
        }

    }

    public class Apprentice : Customer 
    {
        public Apprentice(int customerID, string customerName) : base(customerID, customerName)
        {
            Patience = 3; // Apprentices have a patience level of 3
            PreferredItems = new List<int> { 1, 2 };
        }
        

    }

    public class Adventurer : Customer
    {
        public Adventurer(int customerID, string customerName) : base(customerID, customerName)
        {
            Patience = 4; // Adventurers have a patience level of 4
            PreferredItems = new List<int> { 1, 2, 3, 4 };
        }

    }
}
