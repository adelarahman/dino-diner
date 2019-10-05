/*  Side.cs
*   Author: Nathan Bean
*   Modified By: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    /// <summary>
    /// Abstract class that is inherited into the entrees for the price, calories, read-only ingredients, and size.
    /// </summary>
    public abstract class Side : IMenuItem
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
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
