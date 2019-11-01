/*  Water.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The public class for the drink Water that inherits from the Drink base class.
    /// </summary>
    public class Water : Drink
    {

        /// <summary>
        /// A public bool property that holds if lemon should be added to the drink. Is initially false.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The private size of the side for this class.
        /// </summary>
        private Size size;

        /// <summary>
        /// A public size property. The private size is equal to the value. The set switches price and calories depending on the size value. The get returns the private size.
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.10;
                    Calories = 0;
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Description");
                    NotifyOfPropertyChanged("Price");
                }
                else if (size == Size.Medium)
                {
                    Price = .10;
                    Calories = 0;
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Description");
                    NotifyOfPropertyChanged("Price");
                }
                else
                {
                    Price = .10;
                    Calories = 0;
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Description");
                    NotifyOfPropertyChanged("Price");
                }
            }
        }

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }

        /// <summary>
        /// Override the Special method to return a string array of all the specials in the class.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice)
                {
                    special.Add("Hold Ice");
                }
                if (Lemon)
                {
                    special.Add("Add Lemon");
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
                ingredients.Add("Water");
                if(Lemon)
                {
                    ingredients.Add("Lemon");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// A public constructor setting the price and calories for this class.
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
        }

        /// <summary>
        /// A public method, named AddLemon, that sets the Lemon property to be true. Also adds lemon to the ingredient list.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
        }
    }
}
