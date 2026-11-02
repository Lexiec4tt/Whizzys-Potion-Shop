using System;

namespace Whizzys_Potion_Shop {
    public class OrderItem
    {
        public int quantity { get; set; }
        public int potionID { get; set; }

        public void AddOrderItem(int potionID, int quantity)
        {
            this.potionID = potionID;
            this.quantity = quantity;
        }
    }
}
