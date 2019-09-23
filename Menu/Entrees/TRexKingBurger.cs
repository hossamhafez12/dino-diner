﻿using System;
using System.Collections.Generic;
using System.Text;
namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");

                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        public void HoldMustard()
        {
            this.mustard = false;
        }
        public void HoldMayo()
        {
            this.mayo = false;
        }
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        public void HoldTomato()
        {
            this.tomato = false;
        }
        public void HoldOnion()
        {
            this.onion = false;
        }
    }
}

