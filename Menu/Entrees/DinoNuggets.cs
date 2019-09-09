using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public uint nuggetCount = 6;
        public double nuggetPrice = 0.25;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { nuggetCount + "Chicken Nugget" };
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59*6;
        }

        public void AddNugget()
        {
            nuggetCount++;
            Price += nuggetPrice;
            Calories += 59;
        }


    }
}
