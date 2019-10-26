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

        public List<IOrderItem> items;

        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }
        /// <summary>
        /// Creates a new Order instance.
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void OnCollectionChanged(object sender, EventArgs args) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
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

        double salesTaxRate = 0;

        /// <summary>
        /// Gets and protected sets the sale tax rate.
        /// </summary>
        public double SalesTaxRate {
            get
            {
                return salesTaxRate;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

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
