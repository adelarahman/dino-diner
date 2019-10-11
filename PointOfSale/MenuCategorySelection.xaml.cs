/*  MenuCategorySelection.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Intiializes this xaml page.
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A click on combo takes you to the ComboSelection xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// A click on entrees takes you to the EntreeSelection xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SelectEntrees(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// A click on sides takes you to the SideSelection xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SelectSides(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// A click on drinks takes you to the DrinkSelection xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
