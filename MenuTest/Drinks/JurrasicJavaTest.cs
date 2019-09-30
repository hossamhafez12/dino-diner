using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.Contains<string>("Water", jurrasic.Ingredients);
            Assert.Contains<string>("Coffee", jurrasic.Ingredients);
            Assert.Equal<int>(2, jurrasic.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.Equal<double>(0.59, jurrasic.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.Equal<uint>(2, jurrasic.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, jurrasic.Size);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.False(jurrasic.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.False(jurrasic.roomForCream);
        }
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingSmall()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            jurrasic.Size = Size.Small;
            jurrasic.Size = Size.Small;
            Assert.Equal<double>(0.59, jurrasic.Price);
        }
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingMedium()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            jurrasic.Size = Size.Medium;
            Assert.Equal<double>(0.99, jurrasic.Price);
        }
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingLarge()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            jurrasic.Size = Size.Large;
            Assert.Equal<double>(1.49, jurrasic.Price);
        }
        [Fact]
        public void ShouldHaveInvokingHoldIce()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.False(jurrasic.Ice);
        }
        [Fact]
        public void ShouldHaveInvokingLeaveSpaceForCream()
        {
            JurrasicJava jurrasic = new JurrasicJava();
            Assert.False(jurrasic.roomForCream);
        }
    }
}


