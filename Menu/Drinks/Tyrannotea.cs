using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, IMenuItem
    {
        public bool Sweet = false;
        public bool lemon = false;
        public Tyrannotea()
        {

            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if (lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        public void AddLemon()
        {
            this.lemon = true;
        }
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        this.price = 0.99;
                        this.calories = 8;
                        if (Sweet)
                        {
                            this.calories = 16;
                        }
                        break;
                    case Size.Medium:
                        this.price = 1.49;
                        this.calories = 16;
                        if (Sweet)
                        {
                            this.calories = 32;
                        }
                        break;
                    case Size.Large:
                        this.price = 1.99;
                        this.calories = 32;
                        if (Sweet)
                        {
                            this.calories = 64;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public override string ToString()
        {
            if (Sweet)
            {
                return size + " Sweet Tyrannotea";
            }
            else
            return size + " Tyrannotea";
        }
    }
}
