using System;
using System.Collections.Generic;

namespace Whizzys_Potion_Shop
{
	public class OrderManager
	{
        public Customer CurrentCustomer { get; set; }
        public CustomerOrder CurrentOrder { get; set; }
        private static Random random = new Random();

        private int customerIdCounter = 0;

        private int orderIdCounter = 0;
        private string[] wizardNames =
        {
            "Aldric", "Elowen", "Merlin", "Theodora",
            "Ambrose", "Celestine", "Alistair", "Isolde"
        };

        private string[] apprenticeNames =
        {
            "Pip", "Tilly", "Milo", "Wren",
            "Poppy", "Finn", "Juniper", "Theo"
        };

        private string[] adventurerNames =
        {
            "Rowan", "Gideon", "Freya", "Kael",
            "Astrid", "Cedric", "Lyra", "Dorian"
        };
        public void GenerateCustomer()
        {
            int customerType = random.Next(3);

            if (customerType == 0)
                CurrentCustomer = new Wizard(++customerIdCounter, wizardNames[random.Next(wizardNames.Length)]);
            else if (customerType == 1)
                CurrentCustomer = new Apprentice(++customerIdCounter, apprenticeNames[random.Next(apprenticeNames.Length)]);
            else
                CurrentCustomer = new Adventurer(++customerIdCounter, adventurerNames[random.Next(adventurerNames.Length)]);
        }

        public void GenerateCustomerOrder(List<int> unlockedPotions)
        {
            GenerateCustomer();

            CurrentOrder = new CustomerOrder(++orderIdCounter, CurrentCustomer);
            CurrentOrder.GenerateRandomOrder(unlockedPotions);
        }

        public bool DeliverPotion(Potion potion)
        {
            bool accepted = CurrentOrder.EvaluatePotions(potion);

            if (!accepted)
            {
                CurrentCustomer.DecreasePatience();
                return false;
            }

            return true;
        }

        public bool IsOrderComplete()
        {

            return CurrentOrder.Items.Count == 0;
        }

        public void ClearOrder()
        {
            CurrentCustomer = null;
            CurrentOrder = null;
        }
    }

}
