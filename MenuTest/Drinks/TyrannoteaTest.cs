﻿/*  Tyrannotea.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        // The correct default price, calories, ice, size, lemon, and sweet properties.

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        // The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false

        [Fact]
        public void InvokingHoldIceResultsInIcePropertyBeingFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        // That invoking AddLemon() sets results in the Lemon property being true.

        [Fact]
        public void InvokingAddLemonSetsResultsInLemonPropertyToTrue()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        // That setting the sweet property to true results in the right calories for each size

        [Fact]
        public void SweetPropertyToTrueResultsInRightCaloriesForSmall()
        {
            uint teaSmallExpectedCalories = 16;
            Tyrannotea teaSmall = new Tyrannotea();
            teaSmall.AddSugar();
            teaSmall.Size = Size.Small;
            Assert.Equal<uint>(teaSmallExpectedCalories, teaSmall.Calories);
        }

        [Fact]
        public void SweetPropertyToTrueResultsInRightCaloriesForMedium()
        {
            uint teaMediumExpectedCalories = 32;
            Tyrannotea teaMedium = new Tyrannotea();
            teaMedium.AddSugar();
            teaMedium.Size = Size.Medium;
            Assert.Equal<uint>(teaMediumExpectedCalories, teaMedium.Calories);
        }

        [Fact]
        public void SweetPropertyToTrueResultsInRightCaloriesForLarge()
        {
            uint teaLargeExpectedCalories = 64;
            Tyrannotea teaLarge = new Tyrannotea();
            teaLarge.AddSugar();
            teaLarge.Size = Size.Large;
            Assert.Equal<uint>(teaLargeExpectedCalories, teaLarge.Calories);
        }

        // That setting the sweet property to false (after it has been set to true) results in the right calories for each size.

        [Fact]
        public void SweetPropertyToFalseResultsInRightCaloriesForSmall()
        {
            uint teaSmallExpectedCalories = 8;
            Tyrannotea teaSmall = new Tyrannotea();
            teaSmall.AddSugar();
            teaSmall.Sweet = false;
            teaSmall.Size = Size.Small;
            Assert.Equal<uint>(teaSmallExpectedCalories, teaSmall.Calories);
        }

        [Fact]
        public void SweetPropertyToFalseResultsInRightCaloriesForMedium()
        {
            uint teaMediumExpectedCalories = 16;
            Tyrannotea teaMedium = new Tyrannotea();
            teaMedium.AddSugar();
            teaMedium.Sweet = false;
            teaMedium.Size = Size.Medium;
            Assert.Equal<uint>(teaMediumExpectedCalories, teaMedium.Calories);
        }

        [Fact]
        public void SweetPropertyToFalseResultsInRightCaloriesForLarge()
        {
            uint teaLargeExpectedCalories = 32;
            Tyrannotea teaLarge = new Tyrannotea();
            teaLarge.AddSugar();
            teaLarge.Sweet = false;
            teaLarge.Size = Size.Large;
            Assert.Equal<uint>(teaLargeExpectedCalories, teaLarge.Calories);
        }

        // The correct ingredients are given.

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
        }

        // That invoking AddLemon adds lemon to the ingredients.
        [Fact]
        public void InvokingAddLemonAddsLemonToIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains<string>("Lemon", tea.Ingredients);
        }

        
        //That invoking AddSugar adds sugar to the ingredients.
        [Fact]
        public void InvokingAddSugarAddsSugarToIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSugar();
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
        }

        // The description should be correct.

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal((tea.Size.ToString() + " Tyrannotea"), tea.Description);
            tea.Sweet = true;
            Assert.Equal((tea.Size.ToString() + " Sweet Tyrannotea"), tea.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void HoldIceAndAddLemonShouldAddToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void AddIceShouldNotifySpecialChanged()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.HoldIce();
            });
        }

        [Fact]
        public void AddLemonShouldNotifySpecialChanged()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifyPriceChanged(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifyCaloriesChanged(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifySizeChanged(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = size;
            });
        }
    }
}
