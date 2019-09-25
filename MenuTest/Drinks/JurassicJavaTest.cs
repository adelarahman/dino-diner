using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        // The correct default price, calories, ice, size, and SpaceForCream properties.

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }

        // The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(8, java.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false

        [Fact]
        public void InvokingHoldIceResultsInIcePropertyBeingFalse()
        {
            JurrasicJava java = new JurrasicJava();
            java.HoldIce();
            Assert.False(java.Ice);
        }

        // That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.

        [Fact]
        public void InvokingLeaveSpaceForCreamResultsInSpaceForCreamPropertyToTrue()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveSpaceForCream();
            Assert.True(java.RoomForCream);

        }
    }
}
