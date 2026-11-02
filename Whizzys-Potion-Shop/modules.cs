using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_game
{
    internal class modules
    {
        public static Potion Brew(ref Dictionary<string, int> ingredientSet, ref int[] potionCount)
        {
            Potion newPotion;
            if (new SleepPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new SleepPotion();
                potionCount[0] += 1;
            }
            else if (new FeatherFallPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new FeatherFallPotion();
                potionCount[1] += 1;
            }
            else if (new HealingPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new HealingPotion();
                potionCount[2] += 1;
            }
            else if (new LovePotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new LovePotion();
                potionCount[3] += 1;
            }
            else if (new StaminaPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new StaminaPotion();
                potionCount[4] += 1;
            }
            else if (new TotallyNotEvilPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new TotallyNotEvilPotion();
                potionCount[5] += 1;
            }
            else
            {
                newPotion = new ExPotion();
                potionCount[6] += 1;
            }

            // Clears the ingredients tray
            foreach (string key in ingredientSet.Keys)
            {
                ingredientSet[key] = 0;
            }

            return newPotion;
        }

        public static void AddIngredient(ref Dictionary<string, int> ingredientSet, int ingredientID)
        {
            if (ingredientID == 1)
            {
                ingredientSet["Moon Water"] += 1;
            }
            else if (ingredientID == 2)
            {
                ingredientSet["Sun Bloom"] += 1;
            }
            else if (ingredientID == 3)
            {
                ingredientSet["Valerian Root"] += 1;
            }
            else if (ingredientID == 4)
            {
                ingredientSet["Harpy Feather"] += 1;
            }
            else if (ingredientID == 5)
            {
                ingredientSet["Dragon's Blood"] += 1;
            }
            else if (ingredientID == 6)
            {
                ingredientSet["Rosemary"] += 1;
            }
            else if (ingredientID == 7)
            {
                ingredientSet["Mandrake"] += 1;
            }
            else if (ingredientID == 8)
            {
                ingredientSet["Hound Fur"] += 1;
            }
            else if (ingredientID == 9)
            {
                ingredientSet["Pink Salt"] += 1;
            }
            else if (ingredientID == 10)
            {
                ingredientSet["Rabbit's Foot"] += 1;
            }
            else if (ingredientID == 11)
            {
                ingredientSet["Honey"] += 1;
            }
            else if (ingredientID == 12)
            {
                ingredientSet["Rainbowshroom"] += 1;
            }
            else if (ingredientID == 13)
            {
                ingredientSet["Wolfsbane"] += 1;
            }
            else if (ingredientID == 14)
            {
                ingredientSet["Spring Water"] += 1;
            }
        }
    }
}