﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, IMenuItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool roomForCream = false;
        public bool Decaf = false;
        public void LeaveRoomForCream()
        {
            this.roomForCream = true;
        }
        public void AddICe()
        {
            this.Ice = true;
        }
        public JurassicJava()
        {

            this.Ice = false;
            this.Size = Size.Small;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
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
                        this.price = .59;
                        this.calories = 2;
                        break;
                    case Size.Medium:
                        this.price = .99;
                        this.calories = 4;
                        break;
                    case Size.Large:
                        this.price = 1.49;
                        this.calories = 8;
                        break;
                    default:
                        break;
                }
            }
        }
        public override string ToString()
        {
            if (Decaf)
            {
                return size + " Decaf Jurassic Java";
            }
            else
            return size + " Jurassic Java";
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
