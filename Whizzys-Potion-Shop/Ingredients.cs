using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whizzys_Potion_Shop
{
    public abstract class Ingredients
    {
        protected string ingredientName = "";
        protected double cost;

        public bool Buy(ref double balance)
        {
            if (balance >= cost)
            {
                balance -= cost;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class MoonWater : Ingredients
    {
        public MoonWater()
        {
            ingredientName = "Moon Water";
            cost = 40;
        }
    };

    public class SunBloom : Ingredients
    {
        public SunBloom()
        {
            ingredientName = "Sun Bloom";
            cost = 40;
        }
    };

    public class ValerianRoot : Ingredients
    {
        public ValerianRoot()
        {
            ingredientName = "Valerian Root";
            cost = 35;
        }
    };

    public class HarpyFeather : Ingredients
    {
        public HarpyFeather()
        {
            ingredientName = "Harpy Feather";
            cost = 50;
        }
    };

    public class DragonsBlood : Ingredients
    {
        public DragonsBlood()
        {
            ingredientName = "Dragon's Blood";
            cost = 75;
        }
    };

    public class Rosemary : Ingredients
    {
        public Rosemary()
        {
            ingredientName = "Rosemary";
            cost = 40;
        }
    };

    public class Mandrake : Ingredients
    {
        public Mandrake()
        {
            ingredientName = "Mandrake";
            cost = 30;
        }
    };

    public class HoundFur : Ingredients
    {
        public HoundFur()
        {
            ingredientName = "Hound Fur";
            cost = 60;
        }
    };

    public class PinkSalt : Ingredients
    {
        public PinkSalt()
        {
            ingredientName = "Pink Salt";
            cost = 20;
        }
    };

    public class RabbitsFoot : Ingredients
    {
        public RabbitsFoot()
        {
            ingredientName = "Rabbit's Foot";
            cost = 50;
        }
    };

    public class Honey : Ingredients
    {
        public Honey()
        {
            ingredientName = "Honey";
            cost = 20;
        }
    };

    public class Rainbowshroom : Ingredients
    {
        public Rainbowshroom()
        {
            ingredientName = "Rainbowshroom";
            cost = 100;
        }
    };

    public class Wolfsbane : Ingredients
    {
        public Wolfsbane()
        {
            ingredientName = "Wolfsbane";
            cost = 70;
        }
    };

    public class SpringWater : Ingredients
    {
        public SpringWater()
        {
            ingredientName = "Spring Water";
            cost = 30;
        }
    };
}