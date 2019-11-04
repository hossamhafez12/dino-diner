﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
                return ingredients;
            }
        }
        public MeteorMacAndCheese()
        {

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
                        this.Calories = 420;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        break;
                    default:
                        break;
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Ingredients");
            }

        }
        public override string ToString()
        {
            return size + " Meteor Mac and Cheese";
        }
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
