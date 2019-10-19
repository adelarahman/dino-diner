using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        // The description should be correct.

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Empty(trex.Special);
        }

        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                });
        }

        [Fact]
        public void HoldLettuceShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                });
        }

        [Fact]
        public void HoldTomatoShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                });
        }

        [Fact]
        public void HoldOnionsShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                });
        }

        [Fact]
        public void HoldPickleShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                });
        }

        [Fact]
        public void HoldKetchupShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                });
        }

        [Fact]
        public void HoldMustardShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                });
        }

        [Fact]
        public void HoldMayoShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                });
        }

        [Fact]
        public void HoldBunAndLettuceShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                });
        }

        [Fact]
        public void HoldBunAndLettuceAndTomatoShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldTomato();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }, 
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                });
        }

        [Fact]
        public void HoldBunAndLettuceAndTomatoAndOnionsShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldTomato();
            trex.HoldOnion();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                });
        }

        [Fact]
        public void HoldBunAndLettuceAndTomatoAndOnionsAndPickleShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldTomato();
            trex.HoldOnion();
            trex.HoldPickle();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                });
        }

        [Fact]
        public void HoldBunAndLettuceAndTomatoAndOnionsAndPickleAndKetchupShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldTomato();
            trex.HoldOnion();
            trex.HoldPickle();
            trex.HoldKetchup();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                });
        }

        [Fact]
        public void HoldBunAndLettuceAndTomatoAndOnionsAndPickleAndKetchupAndMustardShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldTomato();
            trex.HoldOnion();
            trex.HoldPickle();
            trex.HoldKetchup();
            trex.HoldMustard();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                });
        }

        [Fact]
        public void HoldBunAndLettuceAndTomatoAndOnionsAndPickleAndKetchupAndMustardAndMayoShouldAddToSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldTomato();
            trex.HoldOnion();
            trex.HoldPickle();
            trex.HoldKetchup();
            trex.HoldMustard();
            trex.HoldMayo();
            Assert.Collection<string>(trex.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                },
                item =>
                {
                    Assert.Equal("Hold Tomato", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                });
        }

        [Fact]
        public void HoldBunShouldNotifySpecialChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldBun();
            });
        }

        [Fact]
        public void HoldLettuceShouldNotifySpecialChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldLettuce();
            });
        }

        [Fact]
        public void HoldTomatoShouldNotifySpecialChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldTomato();
            });
        }

        [Fact]
        public void HoldOnionShouldNotifySpecialChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldOnion();
            });
        }

        [Fact]
        public void HoldPickleShouldNotifySpecialChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldPickle();
            });
        }

        [Fact]
        public void HoldKetchupShouldNotifySpecialChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldKetchup();
            });
        }

        [Fact]
        public void HoldMustardShouldNotifySpecialChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMustard();
            });
        }

        [Fact]
        public void HoldMayoShouldNotifySpecialChanged()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMayo();
            });
        }
    }
}
