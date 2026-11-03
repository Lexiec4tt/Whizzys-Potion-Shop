using Economy;
using System;
using System.Collections.Generic;
using GameOrder = Economy.Orders.CustomerOrder;

namespace Whizzys_Potion_Shop
{
	public class OrderManager
	{
        public Customer CurrentCustomer { get; set; }
        public GameOrder CurrentOrder { get; set; }
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

            CurrentOrder = new GameOrder(
                ++orderIdCounter,
                CurrentCustomer.CustomerID,
                CurrentCustomer.Patience
            );

            CurrentOrder.Generate(CurrentCustomer.PreferredItems, unlockedPotions);
        }

        public bool DeliverPotion(Potion potion, EconomyManager economyManager, int basePayment)
        {
            if (!CurrentOrder.Wants(potion.potionID))
            {
                int oldPatience = CurrentCustomer.Patience;

                CurrentCustomer.DecreasePatience();

                int lostPatience = oldPatience - CurrentCustomer.Patience;
                CurrentOrder.Tick(lostPatience);

                return false;
            }

            economyManager.ServePotion(CurrentOrder, potion.potionID, basePayment, 100f);

            return true;
        }

        public bool IsOrderComplete()
        {

            return CurrentOrder.IsComplete;
        }

        public void ClearOrder()
        {
            CurrentCustomer = null;
            CurrentOrder = null;
        }
    }

}
