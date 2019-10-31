/*  ComboSelection.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page, INotifyPropertyChanged
    {
        private Entree entree;

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
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A click on customize combo takes you to the CustomizeCombo xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void OnSelectCustomizeBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                CretaceousCombo cc = new CretaceousCombo(bw);
                order.Add(cc);
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// A click on customize combo takes you to the CustomizeCombo xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void OnSelectCustomizeDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                CretaceousCombo cc = new CretaceousCombo(dn);
                order.Add(cc);
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// A click on customize combo takes you to the CustomizeCombo xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void OnSelectCustomizePBJCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                CretaceousCombo cc = new CretaceousCombo(pbj);
                order.Add(cc);
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// A click on customize combo takes you to the CustomizeCombo xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void OnSelectCustomizePterodactylWingsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings pw = new PterodactylWings();
                CretaceousCombo cc = new CretaceousCombo(pw);
                order.Add(cc);
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// A click on customize combo takes you to the CustomizeCombo xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void OnSelectCustomizeSteakosaurusBugerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                CretaceousCombo cc = new CretaceousCombo(sb);
                order.Add(cc);
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// A click on customize combo takes you to the CustomizeCombo xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void OnSelectCustomizeTRexKingBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trexburger = new TRexKingBurger();
                CretaceousCombo cc = new CretaceousCombo(trexburger);
                order.Add(cc);
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }

        /// <summary>
        /// A click on customize combo takes you to the CustomizeCombo xaml page.
        /// </summary>
        /// <param name="sender">object type.</param>
        /// <param name="args">RoutedEventArgs type.</param>
        void OnSelectCustomizeVelociWrapCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                CretaceousCombo cc = new CretaceousCombo(vw);
                order.Add(cc);
                NavigationService.Navigate(new CustomizeCombo(cc));
            }
        }
    }
}
