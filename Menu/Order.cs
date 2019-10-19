/*  Order.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Order class which represents a new customer order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets and sets the items added to the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        public Order()
        {

        }

        /// <summary>
        /// Total price of all the items in the menu called.
        /// </summary>
        private double totalPrice;

        /// <summary>
        /// Gets the total price from the prices of all order items.
        /// </summary>
        public double SubtotalCost {
            get
            {
                foreach(IOrderItem items in Items)
                {
                    totalPrice += items.Price;
                }
                if (totalPrice < 0)
                {
                    return 0;
                }
                return totalPrice;
            }
        }

        /// <summary>
        /// Gets and protected sets the sale tax rate.
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// Gets the product of the sales tax rate and the sub total cost.
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return this.SubtotalCost * this.SalesTaxRate;
            }
        }

        /// <summary>
        /// Gets the total cost as the sum of the subtotal cost and the sales tax cost.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return this.SubtotalCost + this.SalesTaxCost;
            }
        }
    }
}
