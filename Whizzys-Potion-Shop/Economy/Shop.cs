using System;
using System.Collections.Generic;
using System.Text;

namespace Economy
{
    public class Shop
    {
        public int GetPrice(int basePrice, int day)
        {
            float scaled = basePrice * (1f + EconomyConfig.PriceScaling * (day - 1));
            return (int)Math.Ceiling(scaled);
        }
    }
}
