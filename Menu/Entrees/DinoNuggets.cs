using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        private int nuggetCount = 6;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
                special.Add(nuggetCount - 6 + " extra nuggets");
                return special.ToArray();
            }
        }
    }
}
