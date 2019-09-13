/*  TRexKingBurger.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The class for the T-Rex King Burger menu item that establishes the price, calories, and ingredients that are decided upon by the customer. 
    /// </summary>
    public class TRexKingBurger
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
                List<string> ingredients = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Tomato) ingredients.Add("Tomato");
                if (Onion) ingredients.Add("Onion");
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// This public method sets the T-Rex King Burger price and calories to the ones given.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// This method holds the bun if decided by the customer by making it false.
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }

        /// <summary>
        /// This method holds the lettuce if decided by the customer by making it false.
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }

        /// <summary>
        /// This method holds the tomato if decided by the customer by making it false.
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
        }

        /// <summary>
        /// This method holds the onion if decided by the customer by making it false.
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
        }

        /// <summary>
        /// This method holds the pickle if decided by the customer by making it false.
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
        }

        /// <summary>
        /// This method holds the ketchup if decided by the customer by making it false.
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }

        /// <summary>
        /// This method holds the mustard if decided by the customer by making it false.
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }

        /// <summary>
        /// This method holds the mayo if decided by the customer by making it false.
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
        }
    }
}
