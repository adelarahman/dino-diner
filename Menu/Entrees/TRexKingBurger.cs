/*  TRexKingBurger.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the T-Rex King Burger menu item that establishes the price, calories, and ingredients that are decided upon by the customer. 
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// A private bool that holds if bun is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// A private bool that holds if lettuce is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// A private bool that holds if tomato is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Tomato = true;
        /// <summary>
        /// A private bool that holds if onion is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Onion = true;
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
        /// A private bool that holds if mayo is an ingredient or not. Decided by the customer.
        /// </summary>
        private bool Mayo = true;

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }

        /// <summary>
        /// Overrides the Ingredients property to get and return the ingredients for this class.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                ingredients.Add("Whole Wheat Bun");
                ingredients.Add("Lettuce");
                ingredients.Add("Tomato");
                ingredients.Add("Onion");
                ingredients.Add("Pickle");
                ingredients.Add("Ketchup");
                ingredients.Add("Mustard");
                ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// This public method sets the T-Rex King Burger price, calories, and ingredients to the ones given.
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
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
        /// This method holds the lettuce if decided by the customer by making it false.
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
            this.Lettuce = false;
        }

        /// <summary>
        /// This method holds the tomato if decided by the customer by making it false.
        /// </summary>
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
            this.Tomato = false;
        }

        /// <summary>
        /// This method holds the onion if decided by the customer by making it false.
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
            this.Onion = false;
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

        /// <summary>
        /// This method holds the mayo if decided by the customer by making it false.
        /// </summary>
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
            this.Mayo = false;
        }
    }
}
