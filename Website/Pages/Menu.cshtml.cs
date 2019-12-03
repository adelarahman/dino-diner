/*  Menu.cshtml.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu menu = new Menu();

        public List<IMenuItem> menuEntreeItems;
        public List<IMenuItem> menuSideItems;
        public List<IMenuItem> menuDrinkItems;
        public List<IMenuItem> menuComboItems;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> ingredients { get; set; }

        [BindProperty]
        public double? minPrice { get; set; }

        [BindProperty]
        public double? maxPrice { get; set; }

        public void OnGet()
        {
            menuEntreeItems = menu.AvailableEntrees;
            menuSideItems = menu.AvailableSides;
            menuDrinkItems = menu.AvailableDrinks;
            menuComboItems = menu.AvailableCombos;
        }

        public void OnPost()
        {
            menuEntreeItems = menu.AvailableEntrees;
            menuSideItems = menu.AvailableSides;
            menuDrinkItems = menu.AvailableDrinks;
            menuComboItems = menu.AvailableCombos;

            if (search != null)
            {
                menuEntreeItems = Menu.Search(menuEntreeItems, search);
                menuSideItems = Menu.Search(menuSideItems, search);
                menuDrinkItems = Menu.Search(menuDrinkItems, search);
                menuComboItems = Menu.Search(menuComboItems, search);
            }

            if (ingredients.Count != 0)
            {
                menuEntreeItems = Menu.FilterIngredients(menuEntreeItems, ingredients);
                menuSideItems = Menu.FilterIngredients(menuSideItems, ingredients);
                menuDrinkItems = Menu.FilterIngredients(menuDrinkItems, ingredients);
                menuComboItems = Menu.FilterIngredients(menuComboItems, ingredients);
            }

            if (minPrice != null)
            {
                menuEntreeItems = Menu.FilterMinPrice(menuEntreeItems, (double)minPrice);
                menuSideItems = Menu.FilterMinPrice(menuSideItems, (double)minPrice);
                menuDrinkItems = Menu.FilterMinPrice(menuDrinkItems, (double)minPrice);
                menuComboItems = Menu.FilterMinPrice(menuComboItems, (double)minPrice);
            }
        }
    }
}