using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        
        public double SubtotalCost
        {
            get
            {
                double subtotalCost = 0;
                foreach (IOrderItem item in Items)
                {
                    subtotalCost += item.Price;

                }
                return subtotalCost;
            }
        }
        public double SalesTaxRate
        {
            get; set;
        }
        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }

        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
