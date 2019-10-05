/*  Tyrannotea.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

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
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.10;
                    Calories = 0;
                }
                else if (size == Size.Medium)
                {
                    Price = .10;
                    Calories = 0;
                }
                else
                {
                    Price = .10;
                    Calories = 0;
                }
            }
        }

        /// <summary>
        /// A public constructor setting the price, calories, and read-only ingredients for this class.
        /// </summary>

        public override string ToString()
        {
            return Size.ToString() + " Water";
        }

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water");
        }

        /// <summary>
        /// A public method, named AddLemon, that sets the Lemon property to be true. Also adds lemon to the ingredient list.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }
    }
}
