/*  JurrasicJava.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// The public class for the drink JurrasicJava that inherits from the Drink base class.
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// A public bool property that holds if Ice is an ingredient or not. Overrides the one from the abstract class to be initially false.
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// A public bool property holding if there should be room for cream. Initially false.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// A public bool property holding if the drink should be decaf. Initially false.
        /// </summary>
        public bool Decaf { get; set; } = false;

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

        /// <summary>
        /// A public method, named LeaveRoomForCream that sets the RoomforCream property to be true.
        /// </summary>
        public void LeaveSpaceForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// A public method that adds ice to the drink. Sets the ice property to be true.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// A public constructor setting the price, calories, and read-only ingredients for this class.
        /// </summary>
        public JurrasicJava()
        {
            Price = .59;
            Calories = 2;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }
    }
}
