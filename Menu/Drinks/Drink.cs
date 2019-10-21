/*  Drink.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    /// <summary>
    /// Abstract class that is inherited into the drinks for the price, calories, read-only ingredients, size, and ice.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
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

        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets or sets the ice. Is initially true.
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// A public virtual method for the Ice property. The method, named HoldIce, sets the property to false.
        /// </summary>
        public virtual void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets the Special.
        /// </summary>
        public abstract string[] Special { get; }
    }
}
