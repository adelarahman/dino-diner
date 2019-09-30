/*  PterodactyleWings.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the Pterodactyl Wings menu item that establishes the price, calories, and ingredients. 
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// This public method sets the Pterodactyl Wings price, calories, and ingredients to the ones given.
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }
    }
}
