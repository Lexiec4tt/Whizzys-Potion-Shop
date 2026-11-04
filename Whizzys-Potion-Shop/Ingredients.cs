using Economy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whizzys_Potion_Shop
{
    public abstract class Ingredients
    {
        public string ingredientName = "";
        public int cost { get; set; }
        public int IngredientID { get; set; }
    }

    public class MoonWater : Ingredients
    {
        public MoonWater()
        {
            ingredientName = "Moon Water";
            cost = 30;
            IngredientID = 1;
        }
    };

    public class SunBloom : Ingredients
    {
        public SunBloom()
        {
            ingredientName = "Sun Bloom";
            cost = 20;
            IngredientID = 2;
        }
    };

    public class ValerianRoot : Ingredients
    {
        public ValerianRoot()
        {
            ingredientName = "Valerian Root";
            cost = 25;
            IngredientID = 3;
        }
    };

    public class HarpyFeather : Ingredients
    {
        public HarpyFeather()
        {
            ingredientName = "Harpy Feather";
            cost = 40;
            IngredientID = 4;
        }
    };

    public class DragonsBlood : Ingredients
    {
        public DragonsBlood()
        {
            ingredientName = "Dragon's Blood";
            cost = 65;
            IngredientID = 5;
        }
    };

    public class Rosemary : Ingredients
    {
        public Rosemary()
        {
            ingredientName = "Rosemary";
            cost = 30;
            IngredientID = 6;
        }
    };

    public class Mandrake : Ingredients
    {
        public Mandrake()
        {
            ingredientName = "Mandrake";
            cost = 20;
            IngredientID = 7;
        }
    };

    public class HoundFur : Ingredients
    {
        public HoundFur()
        {
            ingredientName = "Hound Fur";
            cost = 50;
            IngredientID = 8;
        }
    };

    public class PinkSalt : Ingredients
    {
        public PinkSalt()
        {
            ingredientName = "Pink Salt";
            cost = 10;
            IngredientID = 9;
        }
    };

    public class RabbitsFoot : Ingredients
    {
        public RabbitsFoot()
        {
            ingredientName = "Rabbit's Foot";
            cost = 40;
            IngredientID = 10;
        }
    };

    public class Honey : Ingredients
    {
        public Honey()
        {
            ingredientName = "Honey";
            cost = 10;
            IngredientID = 11;
        }
    };

    public class Rainbowshroom : Ingredients
    {
        public Rainbowshroom()
        {
            ingredientName = "Rainbowshroom";
            cost = 90;
            IngredientID = 12;
        }
    };

    public class Wolfsbane : Ingredients
    {
        public Wolfsbane()
        {
            ingredientName = "Wolfsbane";
            cost = 60;
            IngredientID = 13;
        }
    };

    public class SpringWater : Ingredients
    {
        public SpringWater()
        {
            ingredientName = "Spring Water";
            cost = 20;
            IngredientID = 14;
        }
    };
}