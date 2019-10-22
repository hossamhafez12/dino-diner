using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public abstract class Entree: INotifyPropertyChanged, IOrderItem
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public double Price { get; set; }

        public uint Calories { get; set; }

        public virtual List<string> Ingredients { get; }
        public virtual string Description { get; }
        public virtual string[] Special { get; }

    }
}
