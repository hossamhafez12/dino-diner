using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the interface that contains a getter for price, calories and ingredients
    /// </summary>
    public interface IMenuItem
    {
        double Price { get; } 
        uint Calories { get; }

        List<string> Ingredients { get; }
    }
}
