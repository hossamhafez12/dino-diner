﻿/*
 * Drink.cs
 * Author: Hossam Hassan
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }
    public abstract class Drink: INotifyPropertyChanged, IOrderItem
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected double price;
        protected uint calories;
        protected List<string> ingredients = new List<string>();
        protected bool ice = true;
        protected Size size = Size.Small;
        public double Price { get { return price; } set { price = value; } }
        public uint Calories { get { return calories; } set { calories = value; } }
        public bool Ice { get { return ice; } set { ice = value; } }
        public virtual List<string> Ingredients { get { return ingredients; } }
        public void HoldIce()
        {
            this.ice = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Description");
        }
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
        public virtual string Description { get; }
        public virtual string[] Special { get; }
        public string Category { get; } = "Drink";
    }
}
