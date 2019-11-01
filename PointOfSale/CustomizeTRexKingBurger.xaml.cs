/*  CustomizeTRexKingBurger.cs
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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// private variable for this entree.
        /// </summary>
        private TRexKingBurger trexburger;

        /// <summary>
        /// Constructor for this class that takes the class it's referring to as a parameter.
        /// </summary>
        /// <param name="bw">type TRexKingBurger.</param>
        public CustomizeTRexKingBurger(TRexKingBurger trexburger)
        {
            InitializeComponent();
            this.trexburger = trexburger;
        }

        /// <summary>
        /// Holds the bun.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldWholeWheatBun(object sender, RoutedEventArgs args)
        {
            trexburger.HoldBun();
        }

        /// <summary>
        /// Holds the lettuce.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            trexburger.HoldLettuce();
        }

        /// <summary>
        /// Holds the tomato.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            trexburger.HoldTomato();
        }

        /// <summary>
        /// Holds the onion.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            trexburger.HoldOnion();
        }

        /// <summary>
        /// Holds the pickle.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            trexburger.HoldPickle();
        }

        /// <summary>
        /// Holds the ketchup.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            trexburger.HoldKetchup();
        }

        /// <summary>
        /// Holds the mustard.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            trexburger.HoldMustard();
        }

        /// <summary>
        /// Holds the mayo.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            trexburger.HoldMayo();
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
