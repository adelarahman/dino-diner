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
        private TRexKingBurger trexburger;

        public CustomizeTRexKingBurger(TRexKingBurger trexburger)
        {
            InitializeComponent();
            this.trexburger = trexburger;
        }

        private void OnHoldWholeWheatBun(object sender, RoutedEventArgs args)
        {
            trexburger.HoldBun();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            trexburger.HoldLettuce();
        }

        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            trexburger.HoldTomato();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            trexburger.HoldOnion();
        }

        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            trexburger.HoldPickle();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            trexburger.HoldKetchup();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            trexburger.HoldMustard();
        }

        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            trexburger.HoldMayo();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
