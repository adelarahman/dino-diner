/*  JurrasicJava.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {

        public bool RoomForCream { get; set; } = false;

        public bool Decaf { get; set; } = false;

        /// <summary>
        /// The private size of the side for this class.
        /// </summary>
        private Size size;

        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.59;
                    Calories = 2;
                }
                else if (size == Size.Medium)
                {
                    Price = .99;
                    Calories = 4;
                }
                else
                {
                    Price = 1.49;
                    Calories = 8;
                }
            }
        }

        public void LeaveSpaceForCream()
        {
            RoomForCream = true;
        }

        public void AddIce()
        {
            Ice = true;
        }

        public JurrasicJava()
        {
            Ice = false;
            Price = .59;
            Calories = 2;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }
    }
}
