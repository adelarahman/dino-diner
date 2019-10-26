/*  Tyrannotea.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The public class for the drink Tyrannotea that inherits from the Drink base class.
    /// </summary>
    public class Tyrannotea : Drink
    {
        private bool sweet = false;
        /// <summary>
        /// A public bool property that holds if the drink will be sweet. Is initially false.
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                NotifyOfPropertyChanged("Sweet");
                NotifyOfPropertyChanged("Description");
            }
        }

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
        public override Size Size
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
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Size");
                }
                else if (size == Size.Medium)
                {
                    Price = 1.49 * temporary;
                    Calories = 16 * temporary;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Size");
                }
                else
                {
                    Price = 1.99 * temporary;
                    Calories = 32 * temporary;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Size");
                }
            }
        }

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
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
                if (Lemon)
                {
                    special.Add("Add Lemon");
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
                ingredients.Add("Tea");
                if(Sweet)
                {
                    ingredients.Add("Cane Sugar");
                }
                if(Lemon)
                {
                    ingredients.Add("Lemon");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// A public constructor setting the price and calories for this class.
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
        }

        /// <summary>
        /// A public method, named AddSugar, that sets the Sweet property to be true. Also adds cane sugar to the ingredient list.
        /// </summary>
        public void AddSugar()
        {
            Sweet = true;
        }

        /// <summary>
        /// A public method, named AddLemon, that sets the Lemon property to be true. Also adds lemon to the ingredient list.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
        }
    }
}
