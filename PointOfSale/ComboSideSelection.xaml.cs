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
        private Side side;

        public ComboSideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        /// <summary>
        /// Click method for changing the side of a combo.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnChangeSide(object sender, RoutedEventArgs args)
        {
            
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
