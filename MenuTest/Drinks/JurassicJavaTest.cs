using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.Contains<string>("Water", jurrasic.Ingredients);
            Assert.Contains<string>("Coffee", jurrasic.Ingredients);
            Assert.Equal<int>(2, jurrasic.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.Equal<double>(0.59, jurrasic.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.Equal<uint>(2, jurrasic.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.Equal<Size>(Size.Small, jurrasic.Size);

        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.False(jurrasic.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.False(jurrasic.roomForCream);
        }
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingSmall()
        {
            JurassicJava jurrasic = new JurassicJava();
            jurrasic.Size = Size.Small;
            jurrasic.Size = Size.Small;
            Assert.Equal<double>(0.59, jurrasic.Price);
        }
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingMedium()
        {
            JurassicJava jurrasic = new JurassicJava();
            jurrasic.Size = Size.Medium;
            Assert.Equal<double>(0.99, jurrasic.Price);
        }
        [Fact]
        public void ShouldUseCorrectPriceAfterSettingLarge()
        {
            JurassicJava jurrasic = new JurassicJava();
            jurrasic.Size = Size.Large;
            Assert.Equal<double>(1.49, jurrasic.Price);
        }
        [Fact]
        public void ShouldHaveInvokingHoldIce()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.False(jurrasic.Ice);
        }
        [Fact]
        public void ShouldHaveInvokingLeaveSpaceForCream()
        {
            JurassicJava jurrasic = new JurassicJava();
            Assert.False(jurrasic.roomForCream);
        }
        ///////////////////////////////////////
        ///
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            JurassicJava jj = new JurassicJava();
            //Assert.Equal( + " Decaf Jurassic Java", jj.Description);
        }
    }
}


