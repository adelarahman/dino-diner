/*  FlavorSelection.cs
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
using DDFlavor = DinoDiner.Menu.SodasaurusFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// private Sodasaurus for this class.
        /// </summary>
        private Sodasaurus soda;

        /// <summary>
        /// Constructor for this class.
        /// </summary>
        /// <param name="soda"></param>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
        }

        /// <summary>
        /// Click method for changing the flavor of a drink.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnChangeFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                soda.Flavor = (DDFlavor)Enum.Parse(typeof(DDFlavor), element.Tag.ToString());
            }
            NavigationService.GoBack();
        }
    }
}
