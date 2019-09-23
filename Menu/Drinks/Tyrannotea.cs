/*  Tyrannotea.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        public bool Sweet
        {
            get { return false; }
        }

        public bool Lemon
        {
            get { return false; }
        }

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
                uint temp;
                if (Sweet)
                {
                    temp = 2;
                }
                else
                {
                    temp = 1;
                }
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99*temp;
                        Calories = 8*temp;
                        break;
                    case Size.Medium:
                        Price = 1.49*temp;
                        Calories = 16*temp;
                        break;
                    case Size.Large:
                        Price = 1.99*temp;
                        Calories = 32*temp;
                        break;
                }
            }
            get { return size; }
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
            if (Sweet)
            {
                ingredients.Add("Cane Suger");
            }
        }

        public void AddLemon()
        {
            ingredients.Add("Lemon");
        }
    }
}
