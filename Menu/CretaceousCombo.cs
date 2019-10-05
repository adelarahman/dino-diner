/*  CretaceousCombo.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class CretaceousCombo: IMenuItem
    {
        /// <summary>
        /// Gets and sets the Entree for this class.
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Private Side for this class.
        /// </summary>
        private Side side;

        /// <summary>
        /// Gets the side for this class and sets which it is and the size.
        /// </summary>
        public Side Side {
            get { return side; }
            set
            {
                this.side = value;
                this.side.Size = this.size;
            } 
        }

        /// <summary>
        /// Private Drink for this class.
        /// </summary>
        private Drink drink;

        /// <summary>
        /// Gets the drink for this class and sets which it is and the size.
        /// </summary>
        public Drink Drink {
            get { return drink; }
            set
            {
                this.drink = value;
                this.drink.Size = this.size;
            }

        }

        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Private size for this class. Is small.
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets the size and sets it for the drink and side.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// Gets and returns the list of ingredients for this class.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }

        /// <summary>
        /// A public constructor setting the price and calories for this class.
        /// </summary>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
    }
}
