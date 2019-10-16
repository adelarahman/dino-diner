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
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Overrides the Ingredients property to get and return the ingredients for this class.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Flour Tortilla");
                ingredients.Add("Chicken Breast");
                ingredients.Add("Ceasar Dressing");
                ingredients.Add("Romaine Lettuce");
                ingredients.Add("Parmesan Cheese");
                if (Dressing == false)
                {
                    ingredients.Remove("Ceasar Dressing");
                }
                if (Lettuce == false)
                {
                    ingredients.Remove("Romaine Lettuce");
                }
                if (Cheese == false)
                {
                    ingredients.Remove("Parmesan Cheese");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// This public method sets the Veloci Wrap price, calories, and ingredients to the ones given.
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
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
