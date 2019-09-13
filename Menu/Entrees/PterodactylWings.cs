/*  PterodactyleWings.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The class for the Pterodactyl Wings menu item that establishes the price, calories, and ingredients. 
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// A public Price property holding the price for the menu item.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// A public Calories property holding the calories for the menu item.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// A public Ingredients property of a list that contains strings. Holds the menu items and if the customer chose to include certain items they are added to the list.
        /// </summary>
        public List<string> Ingredients
        {
             get
             {
                  List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                  return ingredients;
             }
        }

        /// <summary>
        /// This public method sets the Pterodactyl Wings price and calories to the ones given.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
