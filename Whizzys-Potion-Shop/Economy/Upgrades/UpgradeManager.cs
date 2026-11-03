using System;
using System.Collections.Generic;
using System.Text;
using Economy.Upgrades;
using Economy.Currency;

namespace Economy.Upgrades
{
    public class UpgradeManager
    {
        // readonly list meaning bawal mo sya baguhin, its a developer-made variable
        public IReadOnlyList<Upgrade> All { get; } = new List<Upgrade>
        {
            new(UpgradeType.StirringSpoon, "Stirring Spoon",    200, 0.05f, 5),
            new(UpgradeType.Cauldron,      "Better Cauldron",   600, 0.05f, 3),
            new(UpgradeType.Incense,       "Calming Incense",   250, 0.10f, 5),
            new(UpgradeType.Kindling,      "Better Kindling",   300, 0.06f, 5)
        };

        public Upgrade Get(UpgradeType upgradeType)
        {
            foreach(Upgrade upgrade in All)
            {

                if (upgrade.Type == upgradeType) {  return upgrade; }
            }

            throw new ArgumentException($"UPGRADE [{upgradeType}] NOT FOUND!");
        }

        public bool Buy(Upgrade upgrade, Wallet wallet)
        {
            // if player maxed out upgrades
            if (upgrade.IsMaxed) return false;
            // if player is broke
            if (!wallet.Spend(upgrade.CurrentCost)) return false;
            upgrade.Level++;
            return true;
        }
        public float GetBonus(UpgradeType upgradeType)
        {
            // check if upgrade is a valid upgrade
            Upgrade upgrade = Get(upgradeType);
            // level * effect per level--epl (override the previous epl after level up)
            return upgrade.Level * upgrade.EffectPerLevel;
        }
        // for loading saves
        public void SetLevel(UpgradeType upgradeType, int level)
        {
            Upgrade upgrade = Get(upgradeType);
            upgrade.Level = Math.Max(0, Math.Min(level, upgrade.MaxLevel));
        }
    }
}
