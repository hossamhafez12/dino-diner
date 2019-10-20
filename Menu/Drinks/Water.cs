using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water : Drink, IMenuItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool lemon = false;
        public Water()
        {

            this.Size = Size.Small;

        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (lemon) ingredients.Add("Lemon");
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
                        this.price = 0.10;
                        this.calories = 0;
                        break;
                    case Size.Medium:
                        this.price = 0.10;
                        this.calories = 0;
                        break;
                    case Size.Large:
                        this.price = 0.10;
                        this.calories = 0;
                        break;
                    default:
                        break;
                }
            }
        }
        public void AddLemon()
        {
            this.lemon = true;
        }
        public override string ToString()
        {
            return size + " Water";
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

