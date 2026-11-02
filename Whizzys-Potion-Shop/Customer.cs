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
        public int CustomerID { get; protected set; }
        public string CustomerName { get; protected set; }
        public int Patience { get; protected set; }
        public List<int> PreferredItems { get; protected set; }
        public bool HasIllIntentions { get; private set; } 

        public Customer(int customerID, string customerName)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            HasIllIntentions = SetIllIntentions();
        }

        public virtual string Greet()
        {
            if (HasIllIntentions)
            {
                return "";
            }
            else
            { 
                return "";
            }
        }

        public virtual string PlaceOrderDialogue()
        {
            if (HasIllIntentions)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        public virtual string ReactToRefusal()
        {
            if (HasIllIntentions)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        public virtual string ReactToAcceptance()
        {
            if (HasIllIntentions)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        public virtual string ReactToCorrectOrder()
        {
            if (HasIllIntentions)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        public virtual string ReactToWrongOrder()
        {
            if (HasIllIntentions)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        public virtual string ReactToPatienceDepletion()
        {
            if (HasIllIntentions)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        public virtual string CompletedOrder()
        {
            if (HasIllIntentions)
            {
                return "";
            }
            else
            {
                return "";
            }
        }

        public virtual string LeaveShop()
        {
            if (HasIllIntentions)
            {
                return "";
            }
            else
            {
                return "";
            }
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
            Patience = 6; // Apprentices have a patience level of 6
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
