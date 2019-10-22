using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest: Order
    {
        [Theory]
        [InlineData(5)]
        public void PriceShouldBeItSum(double Price)
        {
            CretaceousCombo c = new CretaceousCombo(new MockEntree(5));
            c.Side = new MockSide(5);
            c.Drink = new MockDrink(5);
            Assert.Equal(TotalCost, c.Price);
        }
    }
}
