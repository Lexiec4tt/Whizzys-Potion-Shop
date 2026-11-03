using System;
using System.Collections.Generic;
using System.Text;

namespace Economy.Unlocks
{
    public class PotionUnlocks
    {
        private readonly HashSet<int> _Unlocked = new();
        private readonly Dictionary<int, UnlockRule> _Rules = new();

        public IReadOnlyCollection<int> Unlocked => _Unlocked;

        // if potion becomes unlocked, this event pops up
        public event Action<int>? PotionUnlocked;
        public bool IsUnlocked(int potionId) => _Unlocked.Contains(potionId);
        // the 3 starter potions, ito ung method nila
        public void AddStarter(int potionId) => _Unlocked.Add(potionId);

        // potion that unlocks on a day and/or a different cost of crowns
        public void AddRule(int potionId, int unlockDay, int cost) =>
            _Rules[potionId] = new UnlockRule(unlockDay, cost);
        public List<int> CheckDayUnlocks(int currentDay)
        {
            List<int> newlyUnlocked = new List<int>();

            foreach(var pair in _Rules)
            {
                // check if potion is within the day and if it is fully paid
                if (pair.Value.Cost == 0 && currentDay >= pair.Value.UnlockDay)
                {
                    if (Unlock(pair.Key))
                    {
                        newlyUnlocked.Add(pair.Key);
                    }
                }
          
            }
            return newlyUnlocked;
        }


        // all rules must be followed (no rules means null and it just goes to true right away unless brokie ka
        public bool TryBuy(int potionId, Currency.Wallet playerBalance, int currentDay)
        {
            if (IsUnlocked(potionId)) return false;
            // if the rules is null, meaning it violates the rules
            if (!_Rules.TryGetValue(potionId, out UnlockRule? rule)) return false;
            if (currentDay < rule.UnlockDay) return false;
            if (!playerBalance.Spend(rule.Cost)) return false;

            return Unlock(potionId);
        }
        public int GetCost(int potionId)
        {
            if (_Rules.ContainsKey(potionId))
            {
                UnlockRule Rule = _Rules[potionId];
                return Rule.Cost;
            }

            return 0; // no rule for this potion, costs nothing lmao
        }

        public bool Unlock(int potionId)
        {
            if (!_Unlocked.Add(potionId)) return false;
            PotionUnlocked?.Invoke(potionId);
            return true;
        }

        // for loading saves
        public void SetUnlocked(IEnumerable<int> potionIds)
        {
            _Unlocked.Clear();
            foreach (int id in potionIds) _Unlocked.Add(id);
        }
    }
    public class UnlockRule
    {
        public int UnlockDay { get; }
        public int Cost { get; }

        public UnlockRule(int unlockDay, int cost)
        {
            UnlockDay = unlockDay;
            Cost = cost;
        }
    }
}
