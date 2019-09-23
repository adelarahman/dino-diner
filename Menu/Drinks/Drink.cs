using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public abstract class Drink
    {
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients
        {
            get { return ingredients; }
        }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        public virtual bool Ice
        {
            get { return true; }
        }

        public void HoldIce()
        {
            Ice.Equals(false);
        }
    }
}
