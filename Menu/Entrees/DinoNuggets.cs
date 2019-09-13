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
    public class DinoNuggets
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
        /// a private uint that holds the amount of nuggets in this menu item. Is initially six but can be added to.
        /// </summary>
        private uint NuggetCount = 6;

        /// <summary>
        /// A public Ingredients property of a list that contains strings. Holds the menu items and if the customer chose to include more of the same item it is added to the list.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < NuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// This public method sets the Dino nuggets price and calories to the ones given.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6;
        }

        /// <summary>
        /// This public method increases the nugget count by one each time it is called and increases the calories and the price by the numbers given. 
        /// </summary>
        public void AddNugget()
        {
            NuggetCount++;
            Price += 0.25;
            Calories += 59;
        }
    }
}
