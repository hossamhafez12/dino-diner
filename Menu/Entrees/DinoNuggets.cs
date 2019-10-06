﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, IMenuItem
    {
        private int nuggetCount = 6;
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
            
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
        public void AddNugget()
        {
            nuggetCount++;
            Price += 0.25;
            Calories += 59;
        }
    }
}
