using System;
using System.Collections.Generic;
using System.Text;
namespace DinoDiner.Menu
{
    public class Fryceritops : Side, IMenuItem
    {
        public Fryceritops()
        {
            this.Ingredients.Add("Potato");
            this.Ingredients.Add("Salt");
            this.Ingredients.Add("Vegetable Oil");
            this.Size = Size.Small;

        }

        public override Size Size
        {
            set
            {
                base.size = value;
                switch (size)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 222;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;
                    default:
                        break;
                }
            }

        }
        public override string ToString()
        {
            return size + " Friceritops";
        }
    }
}
