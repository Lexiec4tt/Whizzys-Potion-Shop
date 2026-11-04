using Economy.Orders;
using Economy.Upgrades;
using Economy.Currency;
using Economy.FileHandling;
using Economy.Unlocks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Economy
{
    public class EconomyManager
    {
        public string PlayerName { get; set; } = "No Name";
        public Wallet PlayerBalance { get; }
        public UpgradeManager UpgradeSystem { get; }
        public DayManager Day { get; }
        public Shop Shop { get; } = new Shop();
        public PotionUnlocks UnlockedPotions { get; } = new PotionUnlocks();

        // readonly variables
        public int Balance => PlayerBalance.Balance;

        public bool CanAfford(int amount) => PlayerBalance.CanAfford(amount);

        public EconomyManager()
        {
            PlayerBalance = new Wallet(EconomyConfig.StartingBalance);
            UpgradeSystem = new UpgradeManager();
            Day = new DayManager();
        }

        public int ServePotion(CustomerOrder order, int potionId, int basePayment, float quality)
        {
            // if its the wrong potion, no pay
            if (!order.Serve(potionId)) return 0;

            int earning = PaymentCalculator.Calculate(order, basePayment, quality, UpgradeSystem);
            if (earning > 0)
            {
                PlayerBalance.Receive(earning);
                Day.RecordEarning(earning);
            }
            if (order.IsComplete) Day.RecordCustomer();
            return earning;
        }

        // UPGRADES
        public bool BuyUpgrade(UpgradeType upgradeType)
        {
            Upgrade upgrade = UpgradeSystem.Get(upgradeType);
            int cost = upgrade.CurrentCost;

            // if brokie
            if (!UpgradeSystem.Buy(upgrade, PlayerBalance)) return false;
            Day.RecordExpenses(cost);
            return true;
        }

        // end the day
        public DaySummary EndDay()
        {
            DaySummary Summary = Day.EndDay();
            Summary.NewUnlocks.AddRange(UnlockedPotions.CheckDayUnlocks(Day.CurrentDay));
            return Day.EndDay();
        }

        // buy unlocked potions
        public bool BuyPotionUnlock(int potionId)
        {
            int cost = UnlockedPotions.GetCost(potionId);
            if (!UnlockedPotions.TryBuy(potionId, PlayerBalance, Day.CurrentDay)) return false;

            Day.RecordExpenses(cost);
            return true;
        }

        // MULTIPLIERS
        public float BrewTimeMultiplier =>
            (1f - UpgradeSystem.GetBonus(UpgradeType.Kindling)) *
            (1f - UpgradeSystem.GetBonus(UpgradeType.Cauldron));

        public float StirTimeMultiplier => 1f - UpgradeSystem.GetBonus(UpgradeType.StirringSpoon);
        public float PatienceMultiplier => 1f - UpgradeSystem.GetBonus(UpgradeType.Incense);

        // when buying ingredients
        public int BuyIngredient(int basePrice)
        {
            int cost = Shop.GetPrice(basePrice, Day.CurrentDay);
            if (!PlayerBalance.Spend(cost)) return -1;

            Day.RecordExpenses(cost);
            return cost;
        }

        //public bool Save(string PATH, Dictionary<int, int>? inventory = null, List<int>? unlockedPotions = null)
        //{
        //    SaveData saveData = new SaveData
        //    {
        //        Balance = PlayerBalance.Balance,
        //        CurrentDay = Day.CurrentDay,
        //        Inventory = inventory ?? new Dictionary<int, int>(), // if there is no items in inventory
        //        UnlockedPotions = UnlockedPotions.Unlocked.ToList() // if there are no unlocked potion
        //    };

        //    foreach (Upgrade upgrade in UpgradeSystem.All) { saveData.UpgradeLevels[upgrade.Type.ToString()] = upgrade.Level; }

        //    return DataHandling.Save(saveData, PATH);
        //}

        // list all saves in load saves screen

        public static List<SaveData> GetAllSaves() => DataHandling.LoadAll();

        // save bby player name
        public bool Save(string playerName, Dictionary<int, int>? Inventory = null)
        {
            SaveData saveData = new SaveData
            {
                PlayerName = playerName,
                Balance = PlayerBalance.Balance,
                CurrentDay = Day.CurrentDay,
                Inventory = Inventory ?? new Dictionary<int, int>(),
                UnlockedPotions = UnlockedPotions.Unlocked.ToList()
            };

            foreach (Upgrade upgrade in UpgradeSystem.All)
            {
                saveData.UpgradeLevels[upgrade.Type.ToString()] = upgrade.Level;
            }

            return DataHandling.Save(saveData, DataHandling.PathFor(playerName));
        }

        // load by playerName
        public SaveData? Load(string playerName)
        {
            SaveData? loadData = DataHandling.Load(DataHandling.PathFor(playerName));
            if (loadData == null) return null;

            PlayerBalance.SetBalance(loadData.Balance);
            Day.SetDay(loadData.CurrentDay);
            UnlockedPotions.SetUnlocked(loadData.UnlockedPotions);

            foreach (var pair in loadData.UpgradeLevels)
            {
                if (Enum.TryParse(pair.Key, out UpgradeType upgradeType)) UpgradeSystem.SetLevel(upgradeType, pair.Value);
            }
            return loadData;
        }
    }
}