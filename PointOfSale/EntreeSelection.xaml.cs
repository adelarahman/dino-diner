﻿/*  EntreeSelection.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page, INotifyPropertyChanged
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
        /// Initializes this xaml page.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes this xaml page for the entree.
        /// </summary>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
        }

        /// <summary>
        /// A click on brontowurst adds this entree and goes back to the menu.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnSelectBruntoWurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                order.Add(bw);
                NavigationService.Navigate(new CustomizeBrontowurst(bw));
            }
        }

        /// <summary>
        /// A click on dino nugget adds this entree and goes back to the menu.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                order.Add(dn);
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            }
        }

        /// <summary>
        /// A click on pbj adds this entree and goes back to the menu.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePBJ(pbj));
            }
            //NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// A click on wings adds this entree and goes back to the menu.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings pw = new PterodactylWings();
                order.Add(pw);
                NavigationService.Navigate(new CustomizePterodactylWings(pw));
            }
        }

        /// <summary>
        /// A click on steakosaurusburger adds this entree and goes back to the menu.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                order.Add(sb);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb));
            }
        }

        /// <summary>
        /// A click on trex burger adds this entree and goes back to the menu.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnSelectTRexKingburger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trexburger = new TRexKingBurger();
                order.Add(trexburger);
                NavigationService.Navigate(new CustomizeTRexKingBurger(trexburger));
            }
        }

        /// <summary>
        /// A click on velociwrap adds this entree and goes back to the menu.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type RoutedEventArgs.</param>
        private void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                order.Add(vw);
                NavigationService.Navigate(new CustomizeVelociWrap(vw));
            }
        }
    }
}
