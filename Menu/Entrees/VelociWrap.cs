/*  VelociWrap.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The class for the Veloci Wrap menu item that establishes the price, calories, and ingredients that are decided upon by the customer. 
    /// </summary>
    public class VelociWrap
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
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// This public method sets the Veloci Wrap price and calories to the ones given.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// This method holds the dressing if decided by the customer by making it false.
        /// </summary>
        public void HoldDressing()
        {
            this.Dressing = false;
        }

        /// <summary>
        /// This method holds the lettuce if decided by the customer by making it false.
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }

        /// <summary>
        /// This method holds the cheese if decided by the customer by making it false.
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
        }
    }
}
