using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
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
                size = value;
                if (size == Size.Small)
                {
                    Price = 0.10;
                    Calories = 0;
                }
                else if (size == Size.Medium)
                {
                    Price = .10;
                    Calories = 0;
                }
                else
                {
                    Price = .10;
                    Calories = 0;
                }
            }
        }

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water");
        }

        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }
    }
}
