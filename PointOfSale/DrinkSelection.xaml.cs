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
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Intiializes this xaml page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A click on flavor takes you to the FlavorSelection xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private Drink drink;

        /// <summary>
        /// A click on tyrannotea enables the lemon and sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void TyrannoteaClicked(object sender, RoutedEventArgs args)
        {
            Lemon.IsEnabled = true;
            SweetDecafFlavor.IsEnabled = true;
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Items.Add(drink);
            }
        }

        /// <summary>
        /// A click on sodasaurus disables the lemon and enables sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SodaSaurusClicked(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavor.IsEnabled = true;
            Lemon.IsEnabled = false;
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Items.Add(drink);
            }
        }

        /// <summary>
        /// A click on jurassic java disables the lemon and enables sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void JurrasicJavaClicked(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavor.IsEnabled = true;
            Lemon.IsEnabled = false;
            if (DataContext is Order order)
            {
                drink = new JurrasicJava();
                order.Items.Add(drink);
            }
        }

        /// <summary>
        /// A click on water enables the lemon and disables sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void WaterClicked(object sender, RoutedEventArgs args)
        {
            Lemon.IsEnabled = true;
            SweetDecafFlavor.IsEnabled = false;
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Items.Add(drink);
            }
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
    }
}
