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
        public bool Sweet { get; set; } = false;

        public bool Lemon { get; set; } = false;

        /// <summary>
        /// The private size of the side for this class.
        /// </summary>
        private Size size;

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

        public void AddSugar()
        {
            Sweet = true;
            ingredients.Add("Cane Suger");
        }

        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }
    }
}
