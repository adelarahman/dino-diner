/*  PrehistoricPBJ.cs
*   Author: Nathan Bean
*   Modified By: Adela Rahman
*/

using System.Collections.Generic;

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
            ingredients.Remove("Peanut Butter");
            this.peanutButter = false;
        }

        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
            this.jelly = false;
        }
    }
}
