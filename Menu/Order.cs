/*  Order.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Order class which represents a new customer order.
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invokes a notify of new property changed.
        /// </summary>
        /// <param name="propertyname">type string.</param>
        protected void NotifyOfPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        /// <summary>
        /// Gets and sets the items added to the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        public Order()
        {
            Items.CollectionChanged += OnCollectionChanged;
        }

        public void OnCollectionChanged(object sender, EventArgs args) {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
        }

        /// <summary>
        /// Gets the total price from the prices of all order items.
        /// </summary>
        public double SubtotalCost {
            get
            {
                double totalPrice = 0;
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
