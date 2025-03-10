﻿/*  WaterTest.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        // The correct default price, calories, ice, size, and lemon properties.

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }

        // The correct price and calories after changing to small, medium, and large sizes.

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false.

        [Fact]
        public void InvokingHoldIceResultsInIcePropertyBeingFalse()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        // That invoking AddLemon() sets results in the Lemon property being true.

        [Fact]
        public void InvokingAddLemonSetsResultsInLemonPropertyToTrue()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        // The correct ingredients are given.

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Water water = new Water();
            List<string> ingredients = water.Ingredients;
            Assert.Contains<string>("Water", ingredients);
        }

        // That invoking AddLemon adds lemon to the ingredients.
        [Fact]
        public void InvokingAddLemonAddsLemonToIngredients()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains<string>("Lemon", water.Ingredients);
        }

        // The description should be correct.

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Water water = new Water();
            Assert.Equal((water.Size.ToString() + " Water"), water.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void HoldIceAndAddLemonShouldAddToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
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
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.HoldIce();
            });
        }

        [Fact]
        public void AddLemonShouldNotifySpecialChanged()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifySizeChanged(Size size)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = size;
            });
        }
    }
}
