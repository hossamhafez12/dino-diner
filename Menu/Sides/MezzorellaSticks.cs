using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side, IMenuItem
    {
        public MezzorellaSticks()
        {
            this.Ingredients.Add("Cheese Product");
            this.Ingredients.Add("Breading");
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
                        this.Calories = 540;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        break;
                    default:
                        break;
                }
            }

        }
        public override string ToString()
        {
            return size + " Mezzorella Sticks";
        }
    }
}