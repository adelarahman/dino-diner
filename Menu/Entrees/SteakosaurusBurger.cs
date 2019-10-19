/*  SteakosaurusBurger.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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
        /// Override the Special method to return a string array of all the specials in the class.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Bun)
                {
                    special.Add("Hold Whole Wheat Bun");
                }
                if (!Pickle)
                {
                    special.Add("Hold Pickle");
                }
                if (!Ketchup)
                {
                    special.Add("Hold Ketchup");
                }
                if (!Mustard)
                {
                    special.Add("Hold Mustard");
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
                ingredients.Add("Steakburger Pattie");
                ingredients.Add("Whole Wheat Bun");
                ingredients.Add("Pickle");
                ingredients.Add("Ketchup");
                ingredients.Add("Mustard");
                if (Bun == false)
                {
                    ingredients.Remove("Whole Wheat Bun");
                }
                if (Pickle == false)
                {
                    ingredients.Remove("Pickle");
                }
                if (Ketchup == false)
                {
                    ingredients.Remove("Ketchup");
                }
                if (Mustard == false)
                {
                    ingredients.Remove("Mustard");
                }
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
            this.Bun = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method holds the pickle if decided by the customer by making it false.
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method holds the ketchup if decided by the customer by making it false.
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// This method holds the mustard if decided by the customer by making it false.
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
    }
}
