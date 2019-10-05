/*  IMenuItem.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The interface which all entrees, sides, and drinks will be inheriting from.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Gets the price.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the calories.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets the ingredients.
        /// </summary>
        List<string> Ingredients { get; }
    }
}
