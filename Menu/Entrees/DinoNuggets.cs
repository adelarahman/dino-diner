/*  DinoNuggets.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
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
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Override the Special method to return a string array of all the specials in the class.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                string nuggetSpecial = (NuggetCount - 6) + " Extra Nuggets";
                if(NuggetCount > 6)
                {
                    special.Add(nuggetSpecial);
                }
                return special.ToArray();
            }
        } 

        /// <summary>
        /// Overrides the Ingredients property to get and return the ingredients for this class.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < NuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// This public method sets the Dino nuggets price and calories to the ones given.
        /// </summary>
        ///
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 59*6;
        }

        /// <summary>
        /// This public method increases the nugget count by one each time it is called and increases the calories and the price by the numbers given. 
        /// </summary>
        public void AddNugget()
        {
            NuggetCount = NuggetCount + 1;
            Price += 0.25;
            Calories += 59;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
        }
    }
}
