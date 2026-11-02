using System;

namespace Whizzys_Potion_Shop {
    public class OrderItem
    {
        public int quantity { get; set; }
        public int potionID { get; set; }
        public string potionName { get; set; }

        public void AddOrderItem(int potionID, int quantity)
        {
            this.potionID = potionID;
            this.quantity = quantity;

            switch (potionID)
            {
                case 1:
                    potionName = "Sleep Potion";
                    break;
                case 2:
                    potionName = "Feather Fall Potion";
                    break;
                case 3:
                    potionName = "Healing Potion";
                    break;
                case 4:
                    potionName = "Love Potion";
                    break;
                case 5:
                    potionName = "Stamina Potion";
                    break;
                case 6:
                    potionName = "Totally Not Evil Potion";
                    break;
                default:
                    potionName = "Ex Potion";
                    break;
            }
        }
    }
}
