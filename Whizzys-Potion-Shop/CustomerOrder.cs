using System;
using System.Collections.Generic;

namespace Whizzys_Potion_Shop {

	public class CustomerOrder
	{
		public int orderID { get; set; }
		public int customerID { get; set; }
        public List<int> PreferredItems { get; set; }
        public List<OrderItem> Items = new List<OrderItem>();
        private static readonly Random random = new Random();

        public CustomerOrder( int orderID, Customer customer){
			this.customerID = customer.CustomerID;
			this.orderID = orderID;
            this.PreferredItems = new List<int>(customer.PreferredItems);
        }

        public bool EvaluatePotions(Potion potion)
        {
            foreach (OrderItem item in Items)
            {
                if (item.potionID == potion.potionID && item.quantity > 0)
                {
                    item.quantity--;
                    return true;
                }
                else if (item.potionID == potion.potionID && item.quantity <= 0)
                {
                    Items.RemoveAt(Items.IndexOf(item));
                    return true;
                }
            }
            return false;
        }

        public void GenerateRandomOrder(List<int> unlockedPotions)
        {
            Items.Clear();

            List<int> availablePotions = new List<int>(PreferredItems);

            availablePotions.RemoveAll(potion => !unlockedPotions.Contains(potion));

            if (availablePotions.Count == 0)
            {
                return;
            }

            int remaining = random.Next(1, 6);

            while (remaining > 0)
            {
                int potionID = RandomPotion(availablePotions);

                int quantity;

                if (availablePotions.Count == 1)
                {
                    quantity = remaining;
                }
                else
                {
                    quantity = random.Next(1, remaining + 1);
                }

                OrderItem item = new OrderItem();
                item.AddOrderItem(potionID, quantity);
                Items.Add(item);

                availablePotions.Remove(potionID);
                remaining -= quantity;
            }
        }

        protected int RandomPotion(List<int> availablePotions){
            int index = random.Next(availablePotions.Count);
            return availablePotions[index];
        }
    }
}
