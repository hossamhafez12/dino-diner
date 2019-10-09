﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

   /* public enum Size
    {
        Small,
        Medium, 
        Large
    }*/

    public abstract class Side :  IMenuItem
    {
        protected double price;
        protected uint calories;
        protected List<string> ingredients = new List<string>();
        protected Size size;
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get
            {
                return ingredients;
            }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

    }
}
