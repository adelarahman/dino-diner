/*  Menu.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The public menu class that holds all availale entrees, sides, drinks, and combos in the dino diner menu namespace.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Gets a list containing one instance of every menu item currently offered by DinoDiner.
        /// </summary>
        public List<object> AvailableMenuItems
        {
            get 
            {
                List<object> menu = new List<object>();
                menu.AddRange(AvailableEntrees);
                menu.AddRange(AvailableSides);
                menu.AddRange(AvailableDrinks);
                menu.AddRange(AvailableCombos);
                return menu;
            }
        }

        /// <summary>
        /// Overrides the ToString to make a list where each object in Available menu items is added as their full menu content, each to be followed by a new line.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object ob in AvailableMenuItems)
            {
                sb.Append(ob.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Gets each instance of all the available entrees, adds each to the list.
        /// </summary>
        public List<object> AvailableEntrees
        {
            get
            {
                List<object> entrees = new List<object>();
                Brontowurst brontowurst = new Brontowurst();
                DinoNuggets dinonuggets = new DinoNuggets();
                PrehistoricPBJ pb = new PrehistoricPBJ();
                PterodactylWings pterodactylwings = new PterodactylWings();
                SteakosaurusBurger steakosaurusburger = new SteakosaurusBurger();
                TRexKingBurger trexburger = new TRexKingBurger();
                VelociWrap velociwrap = new VelociWrap();
                entrees.Add(brontowurst);
                entrees.Add(dinonuggets);
                entrees.Add(pb);
                entrees.Add(pterodactylwings);
                entrees.Add(steakosaurusburger);
                entrees.Add(trexburger);
                entrees.Add(velociwrap);
                return entrees;
            }
        }

        /// <summary>
        /// Gets each instance of all the available sides, adds each to the list.
        /// </summary>
        public List<object> AvailableSides
        {
            get
            {
                List<object> sides = new List<object>();
                Fryceritops fryceritops = new Fryceritops();
                MeteorMacAndCheese macandcheese = new MeteorMacAndCheese();
                MezzorellaSticks mezzorellasticks = new MezzorellaSticks();
                Triceritots triceritots = new Triceritots();
                sides.Add(fryceritops);
                sides.Add(macandcheese);
                sides.Add(mezzorellasticks);
                sides.Add(triceritots);
                return sides;
            }
        }

        /// <summary>
        /// Gets each instance of all the available drinks, adds each to the list.
        /// </summary>
        public List<object> AvailableDrinks
        {
            get
            {
                List<object> drinks = new List<object>();
                JurassicJava java = new JurassicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water water = new Water();
                drinks.Add(java);
                drinks.Add(soda);
                drinks.Add(tea);
                drinks.Add(water);
                return drinks;
            }
        }

        /// <summary>
        /// Gets each instance of all the available combos, adds each to the list.
        /// </summary>
        public List<object> AvailableCombos
        {
            get
            {
                List<object> combos = new List<object>();
                Brontowurst brontowurst = new Brontowurst();
                DinoNuggets dinonuggets = new DinoNuggets();
                PrehistoricPBJ pb = new PrehistoricPBJ();
                PterodactylWings pterodactylwings = new PterodactylWings();
                SteakosaurusBurger steakosaurusburger = new SteakosaurusBurger();
                TRexKingBurger trexburger = new TRexKingBurger();
                VelociWrap velociwrap = new VelociWrap();
                CretaceousCombo cone = new CretaceousCombo(brontowurst);
                CretaceousCombo ctwo = new CretaceousCombo(dinonuggets);
                CretaceousCombo cthree = new CretaceousCombo(pb);
                CretaceousCombo cfour = new CretaceousCombo(pterodactylwings);
                CretaceousCombo cfive = new CretaceousCombo(steakosaurusburger);
                CretaceousCombo csix = new CretaceousCombo(trexburger);
                CretaceousCombo cseven = new CretaceousCombo(velociwrap);
                combos.Add(cone);
                combos.Add(ctwo);
                combos.Add(cthree);
                combos.Add(cfour);
                combos.Add(cfive);
                combos.Add(csix);
                combos.Add(cseven);
                return combos;
            }
        } 
    }
}
