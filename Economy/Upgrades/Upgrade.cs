using System;
using System.Collections.Generic;
using System.Text;

namespace Economy.Upgrades
{
    // READ THIS FOR GUIDE ON THE NAMES OF UPGRADETYPES
    public enum UpgradeType
    {
        StirringSpoon, // faster stirring
        Cauldron, // bigger cauldron
        Incense, // more patient customers
        Kindling
    }

    public class Upgrade
    {
        public UpgradeType Type { get; }
        public string Name { get; }
        public int BaseCost { get; }
        public float EffectPerLevel { get; }
        public int MaxLevel { get; }
        public int Level { get; internal set; }

        public bool IsMaxed => Level >= MaxLevel;
        public int CurrentCost => (int)(BaseCost * Math.Pow(1.6, Level));

        public Upgrade(UpgradeType upgradeType, string name, int baseCost, float effectLevel, int maxLevel)
        {
            Type = upgradeType;
            Name = name;
            BaseCost = baseCost;
            EffectPerLevel = effectLevel;
            MaxLevel = maxLevel;
        }
    }
}
