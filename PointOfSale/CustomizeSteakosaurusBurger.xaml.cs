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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        public SteakosaurusBurger burger ;
        public CretaceousCombo combo;
        public CustomizeSteakosaurusBurger(SteakosaurusBurger st)
        {
            InitializeComponent();
            this.burger = st;
        }

        /*public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.burger = (SteakosaurusBurger)combo.Entree;
            this.combo = combo;
        }*/

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            burger.HoldBun();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            burger.HoldPickle();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            burger.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            burger.HoldMustard();
        }
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
    }
}
