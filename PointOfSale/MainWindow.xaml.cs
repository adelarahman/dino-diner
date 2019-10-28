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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes this window.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            MenuCategorySelection.Navigate(new MenuCategorySelection());
            OrderControl.NavigationService = MenuCategorySelection.NavigationService;
        }

        /// <summary>
        /// Passes the data content to the page.
        /// </summary>
        private void PassDataContentToPage()
        {
            if (MenuCategorySelection.Content is Page page)
            {
                page.DataContext = MenuCategorySelection.DataContext;
            }
        }

        /// <summary>
        /// Passes the data content to the page on load completed.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type NavigationEventArgs.</param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }

        public void OnReturnToCategorySelection(object sender, RoutedEventArgs args)
        {
            MenuCategorySelection.NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Passes the data content to the page on data context changed.
        /// </summary>
        /// <param name="sender">type object.</param>
        /// <param name="args">type DependencyPropertyChangedEventArgs.</param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }
    }
}
