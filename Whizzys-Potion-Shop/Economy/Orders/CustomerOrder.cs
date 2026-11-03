using Economy.Upgrades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Economy.Orders
{
    public class CustomerOrder
    {
        private static readonly Random Rng = new();
        private readonly Dictionary<int, int> _Items = new();

        public int OrderId { get; }
        public int CustomerId { get; }
        public int MaxPatience { get; }
        public int PatienceLeft { get; private set; }

        public IReadOnlyDictionary<int, int> Items => _Items;
        public bool IsComplete => _Items.Count == 0;
        public bool HasLeft => PatienceLeft <= 0; // if customer has left

        // for every new order, call this function
        public CustomerOrder(int orderId, int customerId, int basePatience, float patienceMultiplier = 1f)
        {
            OrderId = orderId;
            CustomerId = customerId;
            MaxPatience = Math.Max(1, (int)Math.Round(basePatience * patienceMultiplier));
            PatienceLeft = MaxPatience;
        }

        public void Generate(IEnumerable<int> orderedItems, ICollection<int> unlockedPotions)
        {
            _Items.Clear();
            // make sure all ordered are unlocked potions
            List<int> pool = new List<int>();
            foreach(int potionId in orderedItems)
            {
                if (unlockedPotions.Contains(potionId))
                {
        
                    pool.Add(potionId); // these passed the filtration
                }
            }

            // nothing available then order stays empty
            if (pool.Count == 0) return;

            int totalPotions = Rng.Next(1, 6); // how many potions does the customer want

            for(int i = 0; i< totalPotions; i++)
            {
                int randomIndex = Rng.Next(pool.Count);
                int chosenPotion = pool[randomIndex];

                if (_Items.ContainsKey(chosenPotion))
                {
                    _Items[chosenPotion] = _Items[chosenPotion] + 1;
                }
                else
                {
                    _Items[chosenPotion] = 1;
                }
            }
        }

        public bool Wants(int potionId) => _Items.ContainsKey(potionId);

        // returns true if the potion was the part of the order
        public bool Serve(int potionId)
        {
            if (!_Items.ContainsKey(potionId)) return false;

            int quantityLeft = _Items[potionId];

            if (quantityLeft == 1) _Items.Remove(potionId);
            else _Items[potionId] = quantityLeft - 1;

            return true;
        }

        public void Tick(int amount = 1) => PatienceLeft = Math.Max(0, PatienceLeft - amount);
    }

    public static class PaymentCalculator
    {
        // quality: 0-100
        public static int Calculate(CustomerOrder order, int basePayment, float quality, UpgradeManager upgrades)
        {
            if (quality <= 0 || order.HasLeft) return 0;
            quality = Math.Min(100f, quality + upgrades.GetBonus(UpgradeType.Cauldron) * 100f);
            float payment = basePayment * (quality / 100f);

            float tip = 0f;
            if(quality >= EconomyConfig.TipQualityThreshold)
            {
                float speed = (float)order.PatienceLeft / order.MaxPatience;
                float tipPercent = EconomyConfig.TipPercent * (0.5f + speed) * (1f + upgrades.GetBonus(UpgradeType.Incense));
                tip = basePayment * tipPercent;

            }

            return (int)Math.Round(payment + tip);
        }
    }
}
