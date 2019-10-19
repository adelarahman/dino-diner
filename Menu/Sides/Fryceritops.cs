/*  Fryceritops.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The public class for the side Fryceritops that inherits from the Side base class.
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// The private size of the side for this class.
        /// </summary>
        private Size size;

        /// <summary>
        /// A public override for size. The size is equal to the value. The set switches price and calories depending on the size value. The get returns the size.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Size");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Size");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Size");
                        break;
                }
            }
            get { return size; }
        }

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return Size.ToString() + " Fryceritops";
        }

        /// <summary>
        /// Override the Special method to return a string array of all the specials in the class.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
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
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }

        /// <summary>
        /// A public constructor setting the price, calories, and read-only ingredients for this class.
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
        }
    }
}
