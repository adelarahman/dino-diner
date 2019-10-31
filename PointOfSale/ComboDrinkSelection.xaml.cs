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
    /// Interaction logic for ComboDrinkSelection.xaml
    /// </summary>
    public partial class ComboDrinkSelection : Page, INotifyPropertyChanged
    {
        /// <summary>
        /// private Combo for this class.
        /// </summary>
        private CretaceousCombo combo;

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
        /// Intiializes this xaml page.
        /// </summary>
        public ComboDrinkSelection()
        {
            InitializeComponent();
        }

        public ComboDrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            if (combo.Drink is Tyrannotea)
            {
                Sweet.IsEnabled = true;
                Lemon.IsEnabled = true;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = false;
            }
            if (combo.Drink is Sodasaurus)
            {
                Sweet.IsEnabled = false;
                Lemon.IsEnabled = false;
                Flavor.IsEnabled = true;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = false;
            }
            if (combo.Drink is JurrasicJava)
            {
                Sweet.IsEnabled = false;
                Lemon.IsEnabled = false;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = true;
            }
            if (combo.Drink is Water)
            {
                Sweet.IsEnabled = false;
                Lemon.IsEnabled = true;
                Flavor.IsEnabled = false;
                Ice.IsEnabled = true;
                Decaf.IsEnabled = false;
            }
        }

        /// <summary>
        /// A click on flavor takes you to the FlavorSelection xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if (combo.Drink is Sodasaurus soda)
            {
                NavigationService.Navigate(new FlavorSelection(soda));
            }
        }

        /// <summary>
        /// A click on tyrannotea enables the lemon and sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void TyrannoteaClicked(object sender, RoutedEventArgs args)
        {
            Sweet.IsEnabled = true;
            Lemon.IsEnabled = true;
            Flavor.IsEnabled = false;
            Ice.IsEnabled = true;
            Decaf.IsEnabled = false;
            combo.Drink = new Tyrannotea();
        }

        /// <summary>
        /// A click on sodasaurus disables the lemon and enables sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void SodaSaurusClicked(object sender, RoutedEventArgs args)
        {
            Sweet.IsEnabled = false;
            Lemon.IsEnabled = false;
            Flavor.IsEnabled = true;
            Ice.IsEnabled = true;
            Decaf.IsEnabled = false;
            combo.Drink = new Sodasaurus();
        }

        /// <summary>
        /// A click on jurassic java disables the lemon and enables sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void JurrasicJavaClicked(object sender, RoutedEventArgs args)
        {
            Sweet.IsEnabled = false;
            Lemon.IsEnabled = false;
            Flavor.IsEnabled = false;
            Ice.IsEnabled = true;
            Decaf.IsEnabled = true;
            combo.Drink = new JurrasicJava();
        }

        /// <summary>
        /// A click on water enables the lemon and disables sweet/decaf/flavor radio buttons.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void WaterClicked(object sender, RoutedEventArgs args)
        {
            Sweet.IsEnabled = false;
            Lemon.IsEnabled = true;
            Flavor.IsEnabled = false;
            Ice.IsEnabled = true;
            Decaf.IsEnabled = false;
            combo.Drink = new Water();
        }

        /// <summary>
        /// A click on sweet changes the description.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnSweet(object sender, RoutedEventArgs args)
        {
            if (combo.Drink is Tyrannotea tea)
            {
                tea.Sweet = true;
            }
        }

        /// <summary>
        /// A click on decaf changes the description.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnDecaf(object sender, RoutedEventArgs args)
        {
            if (combo.Drink is JurrasicJava jj)
            {
                jj.Decaf = true;
            }
        }

        /// <summary>
        /// A click on done goes back to the menu category selection.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// A click on lemon changes the special description.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnLemon(object sender, RoutedEventArgs args)
        {
            if (combo.Drink is Water water)
            {
                water.AddLemon();
            }
            else
            {
                Tyrannotea tea = (Tyrannotea)combo.Drink;
                tea.AddLemon();
            }
        }

        /// <summary>
        /// A click on sweet changes the special description.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        private void OnIce(object sender, RoutedEventArgs args)
        {
            if (combo.Drink is Water water)
            {
                water.HoldIce();
            }
            else if (combo.Drink is Tyrannotea tea)
            {
                tea.HoldIce();
            }
            else if (combo.Drink is Sodasaurus soda)
            {
                soda.HoldIce();
            }
            else
            {
                JurrasicJava jj = (JurrasicJava)combo.Drink;
                jj.AddIce();
            }
        }
    }
}
