/*  DrinkSelection.cs
*   Author: Adela Rahman
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using System.Collections.ObjectModel;
using DDSize = DinoDiner.Menu.Size;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page, INotifyPropertyChanged
    {
        private Drink drink;

        /// <summary>
        /// An event handler for PropertyChanged events.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invokes a notify of new property changed.
        /// </summary>
        /// <param name="propertyname">type string.</param>
        protected void NotifyOfPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        /// <summary>
        /// Intiializes this xaml page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            if(drink is Tyrannotea)
            {
                Sweet.IsEnabled = true;
                Lemon.IsEnabled = true;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = false;
            }
            if(drink is Sodasaurus)
            {
                Sweet.IsEnabled = false;
                Lemon.IsEnabled = false;
                Flavor.IsEnabled = true;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = false;
            }
            if(drink is JurrasicJava)
            {
                Sweet.IsEnabled = false;
                Lemon.IsEnabled = false;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = true;
            }
            if(drink is Water)
            {
                Sweet.IsEnabled = false;
                Lemon.IsEnabled = true;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = false;
            }
        }

        /// <summary>
        /// A click on flavor takes you to the FlavorSelection xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if(drink is Sodasaurus soda)
            {
                NavigationService.Navigate(new FlavorSelection(soda));
            }
        }

        /// <summary>
        /// A click on tyrannotea enables the lemon and sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void TyrannoteaClicked(object sender, RoutedEventArgs args)
        {
            Sweet.IsEnabled = true;
            Lemon.IsEnabled = true;
            Flavor.IsEnabled = false;
            Ice.IsEnabled = true;
            Decaf.IsEnabled = false;
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
            }
        }

        /// <summary>
        /// A click on sodasaurus disables the lemon and enables sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SodaSaurusClicked(object sender, RoutedEventArgs args)
        {
            Sweet.IsEnabled = false;
            Lemon.IsEnabled = false;
            Flavor.IsEnabled = true;
            Ice.IsEnabled = true;
            Decaf.IsEnabled = false;
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
            }
        }

        /// <summary>
        /// A click on jurassic java disables the lemon and enables sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void JurrasicJavaClicked(object sender, RoutedEventArgs args)
        {
            Sweet.IsEnabled = false;
            Lemon.IsEnabled = false;
            Flavor.IsEnabled = false;
            Ice.IsEnabled = true;
            Decaf.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new JurrasicJava();
                order.Add(drink);
            }
        }

        /// <summary>
        /// A click on water enables the lemon and disables sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void WaterClicked(object sender, RoutedEventArgs args)
        {
            Sweet.IsEnabled = false;
            Lemon.IsEnabled = true;
            Flavor.IsEnabled = false;
            Ice.IsEnabled = true;
            Decaf.IsEnabled = false;
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
        }

        /// <summary>
        /// A method click that changes the size of the drink.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        /// <summary>
        /// A click on sweet changes the description.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnSweet(object sender, RoutedEventArgs args)
        {
            if (drink is Tyrannotea tea)
            {
                tea.Sweet = true;
            }
        }

        /// <summary>
        /// A click on decaf changes the description.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnDecaf(object sender, RoutedEventArgs args)
        {
            if (drink is JurrasicJava jj)
            {
                jj.Decaf = true;
            }
        }

        /// <summary>
        /// A click on done goes back to the menu category selection.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void Done(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// A click on lemon changes the special description.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnLemon(object sender, RoutedEventArgs args)
        {
            if (drink is Water water)
            {
                water.AddLemon();
            }
            else
            {
                Tyrannotea tea = (Tyrannotea)drink;
                tea.AddLemon();
            }
        }

        /// <summary>
        /// A click on sweet changes the special description.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnIce(object sender, RoutedEventArgs args)
        {
            if (drink is Water water)
            {
                water.HoldIce();
            }
            else if (drink is Tyrannotea tea)
            {
                tea.HoldIce();
            }
            else if (drink is Sodasaurus soda)
            {
                soda.HoldIce();
            }
            else
            {
                JurrasicJava jj = (JurrasicJava)drink;
                jj.AddIce();
            }
        }
    }
}
