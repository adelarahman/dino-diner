/*  PrehistoricPBJ.cs
*   Author: Nathan Bean
*   Modified By: Adela Rahman
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Overrides the ToString() method to follow the naming convention needed.
        /// </summary>
        /// <returns>The name of this item.</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Override the Special method to return a string array of all the specials in the class.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if(!peanutButter)
                {
                    special.Add("Hold Peanut Butter");
                }
                if(!jelly)
                {
                    special.Add("Hold Jelly");
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
                ingredients.Add("Bread");
                ingredients.Add("Peanut Butter");
                ingredients.Add("Jelly");
                if(peanutButter == false)
                {
                    ingredients.Remove("Peanut Butter");
                }
                if (jelly == false)
                {
                    ingredients.Remove("Jelly");
                }
                return ingredients;
            }
        }

        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }

        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
    }
}
