/*  Brontowurst.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The class for the Brontowurst menu item that establishes the price, calories, and number of chicken nuggets that are decided upon by the customer. 
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// A private bool that holds if bread is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Bread = true;
        /// <summary>
        /// A private bool that holds if peppers is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Peppers = true;
        /// <summary>
        /// A private bool that holds if onions is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Onions = true;

        /// <summary>
        /// A public Price property holding the price for the menu item.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// A public Calories property holding the calories for the menu item.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// A public Ingredients property of a list that contains strings. Holds the menu items and if the customer chose to include more of the same item it is added to the list.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bread) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// This public method sets the Brontowurst price and calories to the ones given.
        /// </summary>
        public Brontowurst() {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// This method holds the bun if decided by the customer by making it false.
        /// </summary>
        public void HoldBun()
        {
            this.Bread = false;
        }

        /// <summary>
        /// This method holds the peppers if decided by the customer by making it false.
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
        }

        /// <summary>
        /// This method holds the onion if decided by the customer by making it false.
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
        }
    } 
}
