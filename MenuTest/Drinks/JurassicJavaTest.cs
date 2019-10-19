/*  JurassicJavaTest.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
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

        // That invoking AddIce() results in the Ice property being true

        [Fact]
        public void InvokingAddIceResultsInIcePropertyBeingTrue()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        // That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.

        [Fact]
        public void InvokingLeaveSpaceForCreamResultsInSpaceForCreamPropertyToTrue()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveSpaceForCream();
            Assert.True(java.RoomForCream);

        }

        // The correct ingredients are given.

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
        }

        // The description should be correct.

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal((java.Size.ToString() + " Jurassic Java"), java.Description);
            java.Decaf = true;
            Assert.Equal((java.Size.ToString() + " Decaf Jurassic Java"), java.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void AddIceShouldAddToSpecial()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                });
        }

        [Fact]
        public void LeaveSpaceForCreamShouldAddToSpecial()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveSpaceForCream();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Leave Space For Cream", item);
                });
        }

        [Fact]
        public void AddIceAndLeaveRoomForCreamShouldAddToSpecial()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            java.LeaveSpaceForCream();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                },
                item =>
                {
                    Assert.Equal("Leave Space For Cream", item);
                });
        }

        [Fact]
        public void AddIceShouldNotifySpecialChanged()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
        }

        [Fact]
        public void LeaveSpaceForCreamShouldNotifySpecialChanged()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveSpaceForCream();
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifyPriceChanged(Size size)
        {
            JurrasicJava java = new JurrasicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifyCaloriesChanged(Size size)
        {
            JurrasicJava java = new JurrasicJava();
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifySizeChanged(Size size)
        {
            JurrasicJava java = new JurrasicJava();
            Assert.PropertyChanged(java, "Size", () =>
            {
                java.Size = size;
            });
        }
    }
}
