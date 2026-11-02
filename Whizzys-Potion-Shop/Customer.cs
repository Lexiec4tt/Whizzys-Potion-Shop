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

        public bool HasIllIntentions { get; set; } 

        public Customer(int customerID, string customerName)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            IsServed = false;
            HasIllIntentions = SetIllIntentions();
        }

        public abstract void PlaceOrder(); 

        public virtual void WaitForOrder()
        {
            //something something
        }

        public virtual void PayForOrder()
        {
            //something something
        }

        public virtual void ReceivePotion()
        {
            //something something
        }
        public virtual void LeaveShop()
        {
            //something something
        }

        protected bool SetIllIntentions()
        {
            return _random.Next(2) == 0; // Randomly set ill intentions to true or false
        }

        public void EvaluatePotion(int potion)
        {
            //something something
        }

        protected int RandomPotion(Type customerType)
        {
            switch(customerType)
            {
                case Type t when t == typeof(Wizard):
                    {
                        int[] potions = { 1, 2, 3 };
                        int potionIndex = _random.Next(potions.Length);
                        return potions[potionIndex];
                    }
                case Type t when t == typeof(Apprentice):
                    {
                        int[] potions = { 1, 2 };
                        int potionIndex = _random.Next(potions.Length);
                        return potions[potionIndex];
                    }
                case Type t when t == typeof(Adventurer):
                    {
                        int[] potions = { 1, 2, 3, 4 };
                        int potionIndex = _random.Next(potions.Length);
                        return potions[potionIndex];
                    }
                default:
                    throw new ArgumentException("Unknown customer type");
            }
        }

    }

    public class Wizard : Customer
    {
        public Wizard(int customerID, string customerName) : base(customerID, customerName)
        {
            Patience = 5; // Wizards have a patience level of 5
        }
        public override void PlaceOrder()
        {
            int potionOrder = RandomPotion(this.GetType()); // Randomly select a potion order
            // Additional logic for placing an order
        }

    }

    public class Apprentice : Customer 
    {
        
        public Apprentice(int customerID, string customerName) : base(customerID, customerName)
        {
            Patience = 3; // Apprentices have a patience level of 3
        }
        
        public override void PlaceOrder()
        {

            // Additional logic for placing an order
        }

    }

    public class Adventurer : Customer
    {
        public Adventurer(int customerID, string customerName) : base(customerID, customerName)
        {
            Patience = 4; // Adventurers have a patience level of 4
        }
        public override void PlaceOrder()
        {
            // Additional logic for placing an order
        }
    }
}
