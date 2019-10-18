﻿/*  PterodactyleWings.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The class for the Pterodactyl Wings menu item that establishes the price, calories, and ingredients. 
    /// </summary>
    public class PterodactylWings : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }

        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
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
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }

        /// <summary>
        /// This public method sets the Pterodactyl Wings price, calories, and ingredients to the ones given.
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }
    }
}
