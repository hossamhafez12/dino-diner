using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, IMenuItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        public Sodasaurus()
        {
            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
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
                        this.price = 1.50;
                        this.calories = 112;
                        break;
                    case Size.Medium:
                        this.price = 2.00;
                        this.calories = 156;
                        break;
                    case Size.Large:
                        this.price = 2.50;
                        this.calories = 208;
                        break;
                    default:
                        break;
                }
            }
        }
        public override string ToString()
        {
            return size + " " + flavor + " Sodasaurus";
        }
        public string Description
        {
            get
            {
                return size.ToString();
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
