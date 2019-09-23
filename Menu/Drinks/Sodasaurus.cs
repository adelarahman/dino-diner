/*  Sodasaurus.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum SodasaurusFlavor
    {
        Cola, 
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    }

    public class Sodasaurus : Drink
    {
        /// <summary>
        /// Gets or sets the Flavor.
        /// </summary>
        public virtual SodasaurusFlavor Flavor { get; set; }

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
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get { return size; }
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
