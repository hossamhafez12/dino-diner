using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, IMenuItem, IOrderItem
    {
        public bool Sweet = false;
        public bool lemon = false;
        public Tyrannotea()
        {

            this.Size = Size.Small;
        }
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Description");
        }
        public void IsSweet()
        {
            this.Sweet = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Description");
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
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
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
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
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
        public override string Description
        {
            get
            {
                List<string> description = new List<string>();
                if (Sweet) description.Add("Sweet");
                return this.ToString();
            }
        }
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (lemon)
                {
                    special.Add("Add Lemon");
                }
                if (!ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
