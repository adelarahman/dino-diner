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
        /// The list of unique ingredients from all menu items.
        /// </summary>
        public List<string> allIngredients
        {
            get
            {
                HashSet<string> ingredients = new HashSet<string>();
                foreach (IMenuItem menu in AvailableMenuItems)
                {
                    foreach (string ingredient in menu.Ingredients)
                    {
                        ingredients.Add(ingredient);
                    }
                }
                return new List<string>(ingredients);
            }
        }

        /// <summary>
        /// Gets a list containing one instance of every menu item currently offered by DinoDiner.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get 
            {
                List<IMenuItem> menu = new List<IMenuItem>();
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

        public static List<IMenuItem> Search(List<IMenuItem> menuItems, string searchString)
        {
            List<IMenuItem> result = new List<IMenuItem>();

            foreach (IMenuItem item in menuItems)
            {
                if(item.ToString().Contains(searchString))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<IMenuItem> FilterIngredients(List<IMenuItem> menuItems, List<string> ingredients)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                bool toAdd = true;
                foreach(string ingredient in ingredients)
                {
                    if(item.Ingredients.Contains(ingredient))
                    {
                        toAdd = false;
                    }
                }

                if(toAdd == true)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<IMenuItem> FilterMinPrice(List<IMenuItem> menuItems, double price)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                if (item.Price >= price)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<IMenuItem> FilterMaxPrice(List<IMenuItem> menuItems, double price)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                if (item.Price <= price)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static List<IMenuItem> FilterMenuCategory(List<IMenuItem> menuItems, IMenuItem type)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {

            }
            return result;
        }

        /// <summary>
        /// Gets each instance of all the available entrees, adds each to the list.
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> entrees = new List<IMenuItem>();
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
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> sides = new List<IMenuItem>();
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
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>();
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
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> combos = new List<IMenuItem>();
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
