using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public abstract class Entree
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public virtual List<string> Ingredients { get; }
    }
}
