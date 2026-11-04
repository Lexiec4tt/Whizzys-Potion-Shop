using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whizzys_Potion_Shop
{
    public abstract class Potion
    {
        protected string name = "";
        protected string description = "";
        public double cost;
        public double brewingTime;
        public int potionID { get; protected set; }

        public System.Drawing.Image cauldronImage { get; set; }
        public System.Drawing.Image potionImage { get; set; }

        public Dictionary<string, int> recipe = new Dictionary<string, int>()
        {
            {"Moon Water", 0 },
            {"Sun Bloom", 0 },
            {"Valerian Root", 0 },
            {"Harpy Feather", 0 },
            {"Dragon's Blood", 0 },
            {"Rosemary", 0 },
            {"Mandrake", 0 },
            {"Hound Fur", 0 },
            {"Pink Salt", 0 },
            {"Rabbit's Foot", 0 },
            {"Honey", 0 },
            {"Rainbowshroom", 0 },
            {"Wolfsbane", 0 },
            {"Spring Water", 0 }
        };

        public void TransactPotion(ref double balance)
        {
            balance += cost;
        }

        public bool EvaluatePotionIngredients(Dictionary<string, int> ingredients)
        {
            foreach (string key in recipe.Keys)
            {
                if (ingredients[key] != recipe[key])
                {
                    return false;
                }
            }
            return true;
        }
    };

    public class SleepPotion : Potion
    {
        public SleepPotion()
        {
            name = "A~mimir Potion";
            description = "Honk mimimimi~ Makes you sleep soundly!";
            cost = 150;
            recipe["Moon Water"] = 1;
            recipe["Sun Bloom"] = 1;
            recipe["Valerian Root"] = 1;
            brewingTime = 5;
            potionID = 1;
            cauldronImage = Properties.Resources.cldnmimir;
            potionImage = Properties.Resources.amimir;
        }
    };

    public class FeatherFallPotion : Potion
    {
        public FeatherFallPotion()
        {
            name = "Feather fall Potion";
            description = "Lightens your fall. Fall damage who?";
            cost = 185;
            recipe["Harpy Feather"] = 1;
            recipe["Valerian Root"] = 1;
            recipe["Spring Water"] = 2;
            brewingTime = 6;
            potionID = 2;
            cauldronImage = Properties.Resources.cldnff;
            potionImage = Properties.Resources.featherFall;
        }
    };

    public class HealingPotion : Potion
    {
        public HealingPotion()
        {
            name = "Healing Potion";
            description = "A healing potion! Use if a “Get well soon” is too soon for you!";
            cost = 200;
            recipe["Dragon's Blood"] = 1;
            recipe["Rosemary"] = 1;
            recipe["Mandrake"] = 1;
            brewingTime = 7;
            potionID = 3;
            cauldronImage = Properties.Resources.cldnHeals__1_;
            potionImage = Properties.Resources.healing;
        }
    };

    public class StaminaPotion : Potion
    {
        public StaminaPotion()
        {
            name = "Stamina Potion";
            description = "If you need that big stamina boost. Better than energy drinks!";
            cost = 225;
            recipe["Rabbit's Foot"] = 1;
            recipe["Honey"] = 2;
            recipe["Harpy Feather"] = 1;
            brewingTime = 7.5;
            potionID = 4;
            cauldronImage = Properties.Resources.cldnStam;
            potionImage = Properties.Resources.stamina;
        }
    };

    public class LovePotion : Potion
    {
        public LovePotion()
        {
            name = "LalaLove Potion";
            description = "A love potion. Use responsibly.";
            cost = 200;
            recipe["Moon Water"] = 1;
            recipe["Hound Fur"] = 1;
            recipe["Pink Salt"] = 2;
            brewingTime = 8;
            potionID = 5;
            cauldronImage = Properties.Resources.cldnlalalove;
            potionImage = Properties.Resources.love;
        }
    };

    public class TotallyNotEvilPotion : Potion
    {
        public TotallyNotEvilPotion()
        {
            name = "Prankster's Potion";
            description = "Trust me.";
            cost = 300;
            recipe["Rainbowshroom"] = 1;
            recipe["Mandrake"] = 1;
            recipe["Wolfsbane"] = 1;
            brewingTime = 10;
            potionID = 6;
            cauldronImage = Properties.Resources.cldnprank;
            potionImage = Properties.Resources.prank;
        }
    };

    public class UnstablePotion : Potion
    {
        public UnstablePotion()
        {
            name = "Unstable Potion";
            description = "???";
            brewingTime = 3;
            potionID = 7;
            cauldronImage = Properties.Resources.cldnFailed;
            potionImage = Properties.Resources.broken;
        }
    };
}