/*  IOrderItem.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The interface which all menu items will be inheriting from.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the price.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the Special.
        /// </summary>
        string[] Special { get; }
    }
}
