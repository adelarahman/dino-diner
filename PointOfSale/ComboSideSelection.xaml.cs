/*  ComboSideSelection.cs
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
using DDSide = DinoDiner.Menu.Side;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSideSelection.xaml
    /// </summary>
    public partial class ComboSideSelection : Page
    {
        /// <summary>
        /// private Combo for this class.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for this class that takes the class that is being used as a parameter.
        /// </summary>
        /// <param name="combo">parameter of type CretaceousCombo.</param>
        public ComboSideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// Click method for changing the side of a combo.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnChangeFryceritopsSide(object sender, RoutedEventArgs args)
        {
            combo.Side = new Fryceritops();
        }

        /// <summary>
        /// Click method for changing the side of a combo.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnChangeMeteorMacAndCheeseSide(object sender, RoutedEventArgs args)
        {
            combo.Side = new MeteorMacAndCheese();
        }

        /// <summary>
        /// Click method for changing the side of a combo.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnChangeMezzorellaSticksSide(object sender, RoutedEventArgs args)
        {
            combo.Side = new MezzorellaSticks();
        }

        /// <summary>
        /// Click method for changing the side of a combo.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnChangeTriceritotsSide(object sender, RoutedEventArgs args)
        {
            combo.Side = new Triceritots();
        }

        /// <summary>
        /// Click method that takes you back to the customize combo page.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
