/*  CustomizeDinoNuggets.cs
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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// private variable for this entree.
        /// </summary>
        private DinoNuggets dn;

        /// <summary>
        /// Constructor for this class that takes the class it's referring to as a parameter.
        /// </summary>
        /// <param name="bw">type DinoNuggets.</param>
        public CustomizeDinoNuggets(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }

        /// <summary>
        /// Adds the nugget to the combo.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            dn.AddNugget();
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
