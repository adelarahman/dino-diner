/*  CustomizeBrontowurst.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        /// <summary>
        /// private variable for this entree.
        /// </summary>
        private Brontowurst bw;

        /// <summary>
        /// Constructor for this class that takes the class it's referring to as a parameter.
        /// </summary>
        /// <param name="bw">type Brontowurst.</param>
        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
        }

        /// <summary>
        /// Holds the bun.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldWholeWheatBun(object sender, RoutedEventArgs args)
        {
            bw.HoldBun();
        }

        /// <summary>
        /// Holds the peppers.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            bw.HoldPeppers();
        }

        /// <summary>
        /// Holds the onion.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            bw.HoldOnion();
        }

        /// <summary>
        /// Goes back to the previous page.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
