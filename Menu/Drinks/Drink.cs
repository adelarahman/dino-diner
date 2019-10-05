/*  Drink.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    /// <summary>
    /// Abstract class that is inherited into the drinks for the price, calories, read-only ingredients, size, and ice.
    /// </summary>
    public abstract class Drink : IMenuItem
    {
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
        public List<string> Ingredients
        {
            get { return ingredients; }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

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
        }
    }
}
