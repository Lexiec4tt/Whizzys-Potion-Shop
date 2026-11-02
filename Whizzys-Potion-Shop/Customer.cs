using System;
using System.Collections.Generic;
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

        public bool SetIllIntentions()
        {
            return _random.Next(2) == 0; // Randomly set ill intentions to true or false
        }

        public void EvaluatePotion(int potion)
        {
            //something something
        }

        public int RandomPotion(int[] potions)
        {
            return _random.Next(0, potions.Length); // Randomly select a potion from the array
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
            int[] potionArray = { 1, 2, 3, 4, 5, 6 };
            int potionIndex = RandomPotion(potionArray);
            int selectedPotion = potionArray[potionIndex];

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
