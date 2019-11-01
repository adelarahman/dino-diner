/*  CustomizeVelociWrap.cs
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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        /// <summary>
        /// private variable for this entree.
        /// </summary>
        private VelociWrap vw;

        /// <summary>
        /// Constructor for this class that takes the class it's referring to as a parameter.
        /// </summary>
        /// <param name="bw">type VelociWrap.</param>
        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }

        /// <summary>
        /// Holds the dressing.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            vw.HoldDressing();
        }

        /// <summary>
        /// Holds the lettuce.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            vw.HoldLettuce();
        }

        /// <summary>
        /// Holds the cheese.
        /// </summary>
        /// <param name="sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            vw.HoldCheese();
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
