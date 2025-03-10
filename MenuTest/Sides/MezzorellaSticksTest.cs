﻿using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MezzorellaSticksTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal(0.99, ms.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal<uint>(540, ms.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Contains<string>("Breading", ms.Ingredients);
            Assert.Contains<string>("Cheese Product", ms.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ms.Ingredients);
            Assert.Equal<int>(3, ms.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal<Size>(Size.Small, ms.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal(1.45, ms.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal<uint>(610, ms.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ms.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal(1.95, ms.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal<uint>(720, ms.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ms.Size);
        }

        // The description should be correct.

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Equal((ms.Size.ToString() + " Mezzorella Sticks"), ms.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.Empty(ms.Special);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifyPriceChanged(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, "Price", () =>
            {
                ms.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifyCaloriesChanged(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, "Calories", () =>
            {
                ms.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void SizeShouldNotifySizeChanged(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            Assert.PropertyChanged(ms, "Size", () =>
            {
                ms.Size = size;
            });
        }
    }
}
