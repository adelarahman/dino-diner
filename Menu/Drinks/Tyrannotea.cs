/*  Tyrannotea.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The public class for the drink Tyrannotea that inherits from the Drink base class.
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// A public bool property that holds if the drink will be sweet. Is initially false.
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// A public bool property that holds if lemon should be added to the drink. Is initially false.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The private size of the side for this class.
        /// </summary>
        private Size size;

        /// <summary>
        /// A public size property. The private size is equal to the value. The set switches price and calories depending on the size value. The get returns the private size. If sweet, a temporary variable doubles the price and calories. If not, the variable stays one.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                uint temporary;
                if (Sweet)
                {
                    temporary = 2;
                }
                else
                {
                    temporary = 1;
                }
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.99 * temporary;
                    Calories = 8  * temporary;
                }
                else if (size == Size.Medium)
                {
                    Price = 1.49 * temporary;
                    Calories = 16 * temporary;
                }
                else
                {
                    Price = 1.99 * temporary;
                    Calories = 32 * temporary;
                }
            }
        }

        public override string ToString()
        {
            if (Sweet)
            {
                return Size.ToString() + " Sweet Tyrannotea";
            }
            else
            {
                return Size.ToString() + " Tyrannotea";
            }
        }

        /// <summary>
        /// A public constructor setting the price, calories, and read-only ingredients for this class.
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }

        /// <summary>
        /// A public method, named AddSugar, that sets the Sweet property to be true. Also adds cane sugar to the ingredient list.
        /// </summary>
        public void AddSugar()
        {
            Sweet = true;
            ingredients.Add("Cane Sugar");
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
