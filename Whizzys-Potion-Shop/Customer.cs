using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
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
            return HasIllIntentions
                ? "Ah, there you are. I have a rather... particular request."
                : "Ah, what a lovely little shop! Good day to you.";
        }

        public virtual string PlaceOrderDialogue(CustomerOrder order)
        {
            return $"I would like {GetOrderDescription(order)}, if you please.";
        }

        public virtual string ReactToRefusal()
        {
            return HasIllIntentions
                ? "You would dare refuse me? Very well. I'll remember this."
                : "Ah, I understand. Perhaps another time, then.";
        }

        public virtual string ReactToAcceptance()
        {
            return HasIllIntentions
                ? "Excellent. Let us hope your work meets my expectations."
                : "Splendid! I shall leave the brewing to you.";
        }

        public virtual string ReactToCorrectOrder()
        {
            return HasIllIntentions
                ? "Precisely what I needed. Your little shop may yet prove useful."
                : "Wonderful! A fine example of potion-making.";
        }

        public virtual string ReactToWrongOrder()
        {
            return HasIllIntentions
                ? "This is not what I requested. Are you testing my patience?"
                : "Hmm, I don't believe this is quite right.";
        }

        public virtual string ReactToPatienceDepletion()
        {
            return HasIllIntentions
                ? "Enough! I have no time for this incompetence."
                : "I'm afraid I can wait no longer. Another time, perhaps.";
        }

        public virtual string CompletedOrder()
        {
            return HasIllIntentions
                ? "Our business is concluded. Remember, not a word of this."
                : "A fine day's work! Thank you kindly.";
        }

        public virtual string LeaveShop()
        {
            return HasIllIntentions
                ? "Until next time. Do try to keep your mouth shut."
                : "May your cauldron never run dry!";
        }

        public int DecreasePatience()
        {
            if (Patience > 0 && HasIllIntentions)
            {
                Patience -= 2;
            }
            else if (Patience > 0)
            {
                Patience--;
            }
            return Patience;
        }

        protected bool SetIllIntentions()
        {
            return _random.Next(2) == 0; // Randomly set ill intentions to true or false
        }

        protected string GetOrderDescription(CustomerOrder order)
        {
            List<string> descriptions = new List<string>();

            foreach (OrderItem item in order.Items)
            {
                descriptions.Add($"{item.quantity} {item.potionName}");
            }

            if (descriptions.Count == 1)
                return descriptions[0];

            if (descriptions.Count == 2)
                return $"{descriptions[0]} and {descriptions[1]}";

            return string.Join(", ", descriptions.Take(descriptions.Count - 1))
                   + ", and " + descriptions[descriptions.Count - 1];
        }

    }

    public class Wizard : Customer
    {

        public Wizard(int customerID, string customerName) : base(customerID, customerName)
        {
            Patience = 5; // Wizards have a patience level of 5
            PreferredItems = new List<int> { 1, 2, 3 };
        }

        public override string Greet()
        {
            return HasIllIntentions
                ? "Ah, there you are. I have a rather... particular request."
                : "Ah, what a lovely little shop! Good day to you.";
        }

        public override string PlaceOrderDialogue(CustomerOrder order)
        {
            string items = GetOrderDescription(order);

            return HasIllIntentions
                ? $"I require {items}. I trust you can keep this matter discreet."
                : $"I would like {items}, if you please. My studies have kept me rather busy.";
        }

        public override string ReactToRefusal()
        {
            return HasIllIntentions
                ? "You would dare refuse me? Very well. I'll remember this."
                : "Ah, I understand. Perhaps another time, then.";
        }

        public override string ReactToAcceptance()
        {
            return HasIllIntentions
                ? "Excellent. Let us hope your work meets my expectations."
                : "Splendid! I shall leave the brewing to you.";
        }

        public override string ReactToCorrectOrder()
        {
            return HasIllIntentions
                ? "Precisely what I needed. Your little shop may yet prove useful."
                : "Wonderful! A fine example of potion-making.";
        }

        public override string ReactToWrongOrder()
        {
            return HasIllIntentions
                ? "This is not what I requested. Are you testing my patience?"
                : "Hmm, I don't believe this is quite right.";
        }

        public override string ReactToPatienceDepletion()
        {
            return HasIllIntentions
                ? "Enough! I have no time for this incompetence."
                : "I'm afraid I can wait no longer. Another time, perhaps.";
        }

        public override string CompletedOrder()
        {
            return HasIllIntentions
                ? "Our business is concluded. Remember, not a word of this."
                : "A fine day's work! Thank you kindly.";
        }

        public override string LeaveShop()
        {
            return HasIllIntentions
                ? "Until next time. Do try to keep your mouth shut."
                : "May your cauldron never run dry!";
        }

}

    public class Apprentice : Customer 
    {
        public Apprentice(int customerID, string customerName) : base(customerID, customerName)
        {
            Patience = 6; // Apprentices have a patience level of 6
            PreferredItems = new List<int> { 1, 2 };
        }

        public override string Greet()
        {
            return HasIllIntentions
                ? "Oh! Hello there. I hope you're not too busy..."
                : "Hello! What a charming shop! I've never been here before!";
        }

        public override string PlaceOrderDialogue(CustomerOrder order)
        {
            string items = GetOrderDescription(order);

            return HasIllIntentions
                ? $"Could I have {items}? It's... for something important."
                : $"Could I possibly have {items}? I'm still learning, you see!";
        }

        public override string ReactToRefusal()
        {
            return HasIllIntentions
                ? "Oh... I suppose I'll have to find someone else."
                : "Oh, that's alright! Thank you anyway!";
        }

        public override string ReactToAcceptance()
        {
            return HasIllIntentions
                ? "Really? Thank you! I knew you'd understand."
                : "Yay! Thank you so much! I'll wait right here!";
        }

        public override string ReactToCorrectOrder()
        {
            return HasIllIntentions
                ? "Perfect! This should do nicely. Thank you!"
                : "Wow! You made it perfectly! I hope I can brew like you someday!";
        }

        public override string ReactToWrongOrder()
        {
            return HasIllIntentions
                ? "Um... I don't think this is what I asked for."
                : "Oh! I don't think this is the right one. Could you check again?";
        }

        public override string ReactToPatienceDepletion()
        {
            return HasIllIntentions
                ? "I'm sorry, but I really can't stay any longer."
                : "Oh no! I'm going to be late for my lessons! I should go!";
        }

        public override string CompletedOrder()
        {
            return HasIllIntentions
                ? "Thank you. You've been very helpful."
                : "Everything's here! You're the best! Thank you!";
        }

        public override string LeaveShop()
        {
            return HasIllIntentions
                ? "Goodbye! And please, forget I was ever here."
                : "Bye-bye! Have a magical day!";
        }

}

    public class Adventurer : Customer
    {
        public Adventurer(int customerID, string customerName) : base(customerID, customerName)
        {
            Patience = 4; // Adventurers have a patience level of 4
            PreferredItems = new List<int> { 1, 2, 3, 4 };
        }

        public override string Greet()
        {
            return HasIllIntentions
                ? "You there! I've got business to settle. Let's make this quick."
                : "Well, well! A potion shop! Just what I was looking for.";
        }

        public override string PlaceOrderDialogue(CustomerOrder order)
        {
            string items = GetOrderDescription(order);

            return HasIllIntentions
                ? $"I'll take {items}. And don't go asking what they're for."
                : $"I'll take {items}, please. Got a long journey ahead!";
        }

        public override string ReactToRefusal()
        {
            return HasIllIntentions
                ? "Hmph. Fine. I'll take my business elsewhere."
                : "No worries! I'll try my luck somewhere else.";
        }

        public override string ReactToAcceptance()
        {
            return HasIllIntentions
                ? "Good. Let's get this over with."
                : "Great! I'll be waiting. Don't take too long!";
        }

        public override string ReactToCorrectOrder()
        {
            return HasIllIntentions
                ? "That's the stuff. Exactly what I needed."
                : "Now that's a fine brew! Just what I needed for the road!";
        }

        public override string ReactToWrongOrder()
        {
            return HasIllIntentions
                ? "Wrong potion. I suggest you get it right next time."
                : "Whoa, that's not what I ordered! Mind checking that again?";
        }

        public override string ReactToPatienceDepletion()
        {
            return HasIllIntentions
                ? "I've had enough. Find someone else to bother."
                : "I've waited long enough. Adventure calls!";
        }

        public override string CompletedOrder()
        {
            return HasIllIntentions
                ? "Pleasure doing business. Let's keep it that way."
                : "That's everything! Thanks for the supplies!";
        }

        public override string LeaveShop()
        {
            return HasIllIntentions
                ? "Watch your back, shopkeeper."
                : "Safe travels to you, shopkeeper!";
        }
    }
}
