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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }
        private void SelectBrontowurst(object sender, RoutedEventArgs args)
        {
            Brontowurst wurst = new Brontowurst();
            CretaceousCombo c = new CretaceousCombo(wurst);
            if (DataContext is Order order)
            {
                order.Add(c);
                //NavigationService.Navigate(new CustomizeBrontowurst(c));
            }
        }
        private void SelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            DinoNuggets nuggets = new DinoNuggets();
            CretaceousCombo c = new CretaceousCombo(nuggets);
            if (DataContext is Order order)
            {
                order.Add(c);
                //NavigationService.Navigate(new CustomizeDinoNuggets(c));
            }
        }
        private void SelectSteakosaurus(object sender, RoutedEventArgs args)
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            CretaceousCombo c = new CretaceousCombo(burger);
            if (DataContext is Order order)
            {
                order.Add(c);
                //NavigationService.Navigate(new CustomizeSteakosaurusBurger(c));
            }
        }
        private void SelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            TRexKingBurger Burger = new TRexKingBurger();
            CretaceousCombo c = new CretaceousCombo(Burger);

            if (DataContext is Order order)
            {
                order.Add(c);
                //NavigationService.Navigate(new CustomizeTRexKingBurger(c));
            }
        }
        private void SelectPrehistoric(object sender, RoutedEventArgs args)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            CretaceousCombo c = new CretaceousCombo(pbj);
            if (DataContext is Order order)
            {
                order.Add(c);
                //NavigationService.Navigate(new CustomizePrehistoricPBJ(c));
            }
        }
        private void SelectPterodactyWings(object sender, RoutedEventArgs args)
        {
            PterodactylWings wings = new PterodactylWings();
            CretaceousCombo c = new CretaceousCombo(wings);

            if (DataContext is Order order)
            {
                order.Add(c);
            }
        }
        private void SelectVelociWrap(object sender, RoutedEventArgs args)
        {
            VelociWrap wrap = new VelociWrap();
            CretaceousCombo c = new CretaceousCombo(wrap);
            if (DataContext is Order order)
            {
                order.Add(c);
                //NavigationService.Navigate(new CustomizeVelociWrap(c));
            }
        }
    }
}
