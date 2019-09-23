using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        public bool Lemon
        {
            get { return false; }
        }

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingredients.Add("Water");
            if (Lemon)
            {
                ingredients.Add("Lemon");
            }
        }
    }
}
