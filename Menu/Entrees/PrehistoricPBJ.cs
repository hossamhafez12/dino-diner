﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree, IMenuItem
    {
        private bool peanutButter = true;
        private bool jelly = true;


        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
