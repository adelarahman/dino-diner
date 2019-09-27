/*  Sodasaurus.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// The public class for the drink SodaSaurus that inherits from the Drink base class.
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// A private flavor calling the SodasaurusFlavor enum.
        /// </summary>
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Gets or sets the Flavor.
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// The private size of the side for this class.
        /// </summary>
        private Size size;

        /// <summary>
        /// A public size property. The private size is equal to the value. The set switches price and calories depending on the size value. The get returns the private size.
        /// </summary>
        public Size Size {
            get { return size; }
            set {
                size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                else if(size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                else
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }

        /// <summary>
        /// A public constructor setting the price, calories, and read-only ingredients for this class.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }
    }
}
