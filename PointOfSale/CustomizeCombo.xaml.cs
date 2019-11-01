/*  CustomizeComboSelection.cs
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
using DDSize = DinoDiner.Menu.Size;
using System.ComponentModel;

namespace PointOfSale
{

    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page, INotifyPropertyChanged
    {
        private CretaceousCombo cc;

        /// <summary>
        /// An event handler for PropertyChanged events.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invokes a notify of new property changed.
        /// </summary>
        /// <param name="propertyname">type string.</param>
        protected void NotifyOfPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        /// <summary>
        /// Initializes this xaml page.
        /// </summary>
        public CustomizeCombo(CretaceousCombo cc)
        {
            InitializeComponent();
            this.cc = cc;
        }

        /// <summary>
        /// Takes you to the customize page for the entree that the combo is included in.
        /// </summary>
        /// <param name="Sender">type sender.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        void OnCustomizeEntree(object Sender, RoutedEventArgs args)
        {
            if (cc.Entree is Brontowurst bw)
            {
                NavigationService.Navigate(new CustomizeBrontowurst(bw));
            }
            if (cc.Entree is DinoNuggets dn)
            {
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            }
            if (cc.Entree is PrehistoricPBJ pbj)
            {
                NavigationService.Navigate(new CustomizePBJ(pbj));
            }
            if (cc.Entree is PterodactylWings pw)
            {
                NavigationService.Navigate(new CustomizePterodactylWings(pw));
            }
            if (cc.Entree is SteakosaurusBurger sb)
            {
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb));
            }
            if (cc.Entree is TRexKingBurger trexburger)
            {
                NavigationService.Navigate(new CustomizeTRexKingBurger(trexburger));
            }
            if (cc.Entree is VelociWrap vw)
            {
                NavigationService.Navigate(new CustomizeVelociWrap(vw));
            }
        }

        /// <summary>
        /// A click on sides takes you to the SideSelection xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void OnChangeSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSideSelection(cc));
        }

        /// <summary>
        /// A click on sides takes you to the SideSelection xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void OnChangeDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboDrinkSelection(cc));
        }

        /// <summary>
        /// A click on size changes the sides size and goes back to the menu.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                cc.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
