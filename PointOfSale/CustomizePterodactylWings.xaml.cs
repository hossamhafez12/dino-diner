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
    /// Interaction logic for CustomizePterodactylWings.xaml
    /// </summary>
    public partial class CustomizePterodactylWings : Page
    {
        private PterodactylWings w;
        private CretaceousCombo combo;

        public CustomizePterodactylWings(PterodactylWings wing)
        {
            InitializeComponent();
            this.w = wing;
        }
        public CustomizePterodactylWings(CretaceousCombo combo)
        {
            InitializeComponent();
            this.w = (PterodactylWings)combo.Entree;
            this.combo = combo;
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
