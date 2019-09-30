/*  VelociWrap.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the Veloci Wrap menu item that establishes the price, calories, and ingredients that are decided upon by the customer. 
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// A private bool that holds if dressing is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Dressing = true;
        /// <summary>
        /// A private bool that holds if lettuce is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// A private bool that holds if cheese is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Cheese = true;

        /// <summary>
        /// This public method sets the Veloci Wrap price, calories, and ingredients to the ones given.
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// This method holds the dressing if decided by the customer by making it false.
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
            this.Dressing = false;
        }

        /// <summary>
        /// This method holds the lettuce if decided by the customer by making it false.
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
            this.Lettuce = false;
        }

        /// <summary>
        /// This method holds the cheese if decided by the customer by making it false.
        /// </summary>
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
            this.Cheese = false;
        }
    }
}
