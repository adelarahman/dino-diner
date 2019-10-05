﻿/*  SteakosaurusBurger.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the Steakosaurus Burger menu item that establishes the price, calories, and ingredients that are decided upon by the customer. 
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// A private bool that holds if bun is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// A private bool that holds if pickle is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Pickle = true;
        /// <summary>
        /// A private bool that holds if ketchup is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// A private bool that holds if mustard is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Mustard = true;

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

        /// <summary>
        /// Overrides the Ingredients property to get and return the ingredients for this class.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Whole Wheat Bun");
                ingredients.Add("Pickle");
                ingredients.Add("Ketchup");
                ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// This public method sets the Steakosaurus Burger price, calories, and ingredients to the ones given.
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }

        /// <summary>
        /// This method holds the bun if decided by the customer by making it false.
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
            this.Bun = false;
        }

        /// <summary>
        /// This method holds the pickle if decided by the customer by making it false.
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
            this.Pickle = false;
        }

        /// <summary>
        /// This method holds the ketchup if decided by the customer by making it false.
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
            this.Ketchup = false;
        }

        /// <summary>
        /// This method holds the mustard if decided by the customer by making it false.
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
            this.Mustard = false;
        }
    }
}
