/*  Brontowurst.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the Brontowurst menu item that establishes the price, calories, and ingredients that are decided upon by the customer. 
    /// </summary>
    public class Brontowurst : Entree
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
        /// This public method sets the Brontowurst price, calories, and ingredients to the ones given.
        /// </summary>
        public Brontowurst() {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
            ingredients.Add("Onion");
        }

        /// <summary>
        /// This method holds the bun if decided by the customer by making it false.
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
            this.Bread = false;
        }

        /// <summary>
        /// This method holds the peppers if decided by the customer by making it false.
        /// </summary>
        public void HoldPeppers()
        {
            ingredients.Remove("Peppers");
            this.Peppers = false;
        }

        /// <summary>
        /// This method holds the onion if decided by the customer by making it false.
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
            this.Onions = false;
        }
    } 
}
