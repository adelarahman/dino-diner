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
    /// Interaction logic for CustomizePBJ.xaml
    /// </summary>
    public partial class CustomizePBJ : Page
    {
        private PrehistoricPBJ pbj;

        public CustomizePBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
