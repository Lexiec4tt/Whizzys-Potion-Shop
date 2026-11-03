using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whizzys_Potion_Shop
{
    internal class modules
    {
        public static Potion Brew(Dictionary<string, int> ingredientSet)
        {
            Potion newPotion;

            if (new SleepPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new SleepPotion();
            }
            else if (new FeatherFallPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new FeatherFallPotion();
            }
            else if (new HealingPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new HealingPotion();
            }
            else if (new LovePotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new LovePotion();
            }
            else if (new StaminaPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new StaminaPotion();
            }
            else if (new TotallyNotEvilPotion().EvaluatePotionIngredients(ingredientSet))
            {
                newPotion = new TotallyNotEvilPotion();
            }
            else
            {
                newPotion = new UnstablePotion();
            }

            // Clears the ingredients tray
            foreach (string key in ingredientSet.Keys.ToArray())
            {
                ingredientSet[key] = 0;
            }

            return newPotion;
        }

        public static void collectPotion(Potion potion, int[] potionCount)
        {
            potionCount[potion.potionID - 1] += 1;
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

        public static bool ServeCustomer(int[] potionCount, int[] customerOrder, PictureBox[] potionInventoryImage)
        {
            bool orderEvaluation = false;

            if (potionCount == customerOrder)
            {
                orderEvaluation = true;
            }

            Array.Clear(potionCount, 0, potionCount.Length);

            for (int i = 0; i < potionInventoryImage.Length; i++)
            {
                potionInventoryImage[i].Image = null;
            }

            return orderEvaluation;
        }

        public static int[] ServeCustomer(int[] potionCount, PictureBox[] potionInventoryImage)
        {
            int[] tempPotionCount = potionCount;
            Array.Clear(potionCount, 0, potionCount.Length);

            for (int i = 0; i < potionInventoryImage.Length; i++)
            {
                potionInventoryImage[i].Image = null;
            }

            return tempPotionCount;
        }
    }
}