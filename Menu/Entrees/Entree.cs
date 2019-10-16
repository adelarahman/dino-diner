/*  Entree.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that is inherited into the entrees for the price, calories, and read-only ingredients
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the Special.
        /// </summary>
        public string[] Special { get; }
    }
}
