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

        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
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
