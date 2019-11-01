/*  Sodasaurus.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Flavor");
            }
        }

        /// <summary>
        /// The private size of the side for this class.
        /// </summary>
        private Size size;

        /// <summary>
        /// A public size property. The private size is equal to the value. The set switches price and calories depending on the size value. The get returns the private size.
        /// </summary>
        public override Size Size {
            get { return size; }
            set {
                size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Description");
                }
                else if(size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Description");
                }
                else
                {
                    Price = 2.50;
                    Calories = 208;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Size");
                    NotifyOfPropertyChanged("Description");
                }
            }
        }

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return Size.ToString() + " " + Flavor.ToString() + " Sodasaurus";

        }

        /// <summary>
        /// Override the Special method to return a string array of all the specials in the class.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice)
                {
                    special.Add("Hold Ice");
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
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// A public constructor setting the price and calories for this class.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
        }
    }
}
