using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whizzys_Potion_Shop
{
    internal class modules
    {
        public static Stack<Potion> potionInventory = new Stack<Potion>();

        public static Potion Brew(Dictionary<string, int> ingredientSet, int[] potionCount)
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
                newPotion = new UnstablePotion();
                potionCount[6] += 1;
            }

            // Clears the ingredients tray
            foreach (string key in ingredientSet.Keys.ToArray())
            {
                ingredientSet[key] = 0;
            }

            potionInventory.Push(newPotion);
            return newPotion;
        }

        public static void AddIngredient(Dictionary<string, int> ingredientSet, int ingredientID)
        {
            string[] ingredients =
                {
                    "Moon Water",
                    "Sun Bloom",
                    "Valerian Root",
                    "Harpy Feather",
                    "Dragon's Blood",
                    "Rosemary",
                    "Mandrake",
                    "Hound Fur",
                    "Pink Salt",
                    "Rabbit's Foot",
                    "Honey",
                    "Rainbowshroom",
                    "Wolfsbane",
                    "Spring Water"
                };

            if (ingredientID >= 1 && ingredientID <= ingredients.Length)
            {
                ingredientSet[ingredients[ingredientID - 1]]++;
            }
        }
    }
}