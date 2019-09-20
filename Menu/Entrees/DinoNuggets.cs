/*  DinoNuggets.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The class for the Dino Nuggets menu item that establishes the price, calories, and number of chicken nuggets that are decided upon by the customer. 
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// a private uint that holds the amount of nuggets in this menu item. Is six.
        /// </summary>
        private uint NuggetCount = 6;

        /// <summary>
        /// This public method sets the Dino nuggets price, calories, and ingredients to the ones given.
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 59*6;
            for (int i = 0; i < NuggetCount; i++)
            {
                ingredients.Add("Chicken Nugget");
            }
        }

        /// <summary>
        /// This public method increases the nugget count by one each time it is called and increases the calories and the price by the numbers given. 
        /// </summary>
        public void AddNugget()
        {
            ingredients.Add("Chicken Nugget");
            Price += 0.25;
            Calories += 59;
        }
    }
}
