using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, IMenuItem, INotifyPropertyChanged, IOrderItem 
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        public  Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;

        }

        public override string ToString()
        {
            return "Brontowurst";
        }

        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
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
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onion) special.Add("Hold Onions");
                return special.ToArray();
            }
        }
    }
}