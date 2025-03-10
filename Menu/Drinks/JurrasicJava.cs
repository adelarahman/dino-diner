﻿/*  JurassicJava.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The public class for the drink JurassicJava that inherits from the Drink base class.
    /// </summary>
    public class JurassicJava : Drink
    {

        /// <summary>
        /// A public bool property that holds if Ice is an ingredient or not. Overrides the one from the abstract class to be initially false.
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// A public bool property holding if there should be room for cream. Initially false.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        private bool decaf = false;

        /// <summary>
        /// A public bool property holding if the drink should be decaf. Initially false.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Decaf");
                NotifyOfPropertyChanged("Description");
            }
        }

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
                    Price = 0.59;
                    Calories = 2;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Description");
                }
                else if (size == Size.Medium)
                {
                    Price = .99;
                    Calories = 4;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Description");
                }
                else
                {
                    Price = 1.49;
                    Calories = 8;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Description");
                }
            }
        }

        /// <summary>
        /// A public method, named LeaveRoomForCream that sets the RoomforCream property to be true.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// A public method that adds ice to the drink. Sets the ice property to be true.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size.ToString() + " Decaf Jurassic Java";
            }
            else
            {
                return Size.ToString() + " Jurassic Java";
            }
        }

        /// <summary>
        /// Override the Special method to return a string array of all the specials in the class.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice)
                {
                    special.Add("Add Ice");
                }
                if (RoomForCream)
                {
                    special.Add("Leave Space For Cream");
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
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

        /// <summary>
        /// A public constructor setting the price and calories for this class.
        /// </summary>
        public JurassicJava()
        {
            Price = .59;
            Calories = 2;
        }
    }
}
