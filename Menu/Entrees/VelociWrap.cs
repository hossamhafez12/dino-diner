﻿using System;
using System.Collections.Generic;
using System.Text;
namespace DinoDiner.Menu
{
    public class VelociWrap : Entree, IMenuItem
    {
        private bool lettuce = true;
        private bool dressing= true;
        private bool cheese = true;

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
