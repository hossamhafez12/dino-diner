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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        public Brontowurst wurst;
        public CretaceousCombo combo;
        public CustomizeBrontowurst(Brontowurst bron)
        {
            InitializeComponent();
            this.wurst = bron;
        }

        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.wurst = (Brontowurst)combo.Entree;
            this.combo = combo;
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            this.wurst.HoldBun();
        }
        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {
            this.wurst.HoldPeppers();
        }
        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            this.wurst.HoldOnion();
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
