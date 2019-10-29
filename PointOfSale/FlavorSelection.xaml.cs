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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus soda;

        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            this.soda = soda;
        }

        private void OnSelectCherry(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Cherry;
            NavigationService.Navigate(new DrinkSelection());
        }
        private void OnSelectChocolate(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Chocolate;
            NavigationService.Navigate(new DrinkSelection());
        }
        private void OnSelectCola(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Cola;
            NavigationService.Navigate(new DrinkSelection());
        }
        private void OnSelectLime(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Lime;
            NavigationService.Navigate(new DrinkSelection());
        }
        private void OnSelectOrange(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Orange;
            NavigationService.Navigate(new DrinkSelection());
        }
        private void OnSelectRootBeer(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.RootBeer;
            NavigationService.Navigate(new DrinkSelection());
        }
        private void OnSelectVanilla(object sender, RoutedEventArgs args)
        {
            soda.Flavor = SodasaurusFlavor.Vanilla;
            NavigationService.Navigate(new DrinkSelection());
        }

    }
}
