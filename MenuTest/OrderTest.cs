/*  OrderTest.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    /// <summary>
    /// A mock drink class.
    /// </summary>
    class MockDrink : IOrderItem, INotifyPropertyChanged
    {
        public double Price { get; } = 5;
        public string Description { get; set; }
        public string[] Special { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    /// <summary>
    /// A mock entree class.
    /// </summary>
    class MockEntree : IOrderItem
    {
        public double Price { get; } = -1000;
        public string Description { get; set; }
        public string[] Special { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    /// <summary>
    /// A mock side class.
    /// </summary>
    class MockSide : IOrderItem
    {
        public double Price { get; } = 5;
        public string Description { get; set; }
        public string[] Special { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    /// <summary>
    /// The tests for the order class.
    /// </summary>
    public class OrderTest
    {
        /// <summary>
        /// Sub total cost should be negative.
        /// </summary>
        [Fact]
        public void SubtotalCostShouldBeNegative()
        {
            Order order = new Order();
            MockEntree me = new MockEntree();
            order.Add(me);
            Assert.Equal<double>(0, order.SubtotalCost);
        }

        /// <summary>
        /// Sub total cost should be positive.
        /// </summary>
        [Fact]
        public void SubtotalCostShouldNotBeNegative()
        {
            Order order = new Order();
            MockDrink md = new MockDrink();
            MockSide ms = new MockSide();
            order.Add(md);
            order.Add(ms);
            Assert.Equal<double>(10, order.SubtotalCost);
        }
    }
}
