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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        public VelociWrap wrap;
        public CretaceousCombo combo;
        public CustomizeVelociWrap(VelociWrap st)
        {
            InitializeComponent();
            this.wrap = st;
        }

        public CustomizeVelociWrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.wrap = (VelociWrap)combo.Entree;
            this.combo = combo;
        }

        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {
            wrap.HoldDressing();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            wrap.HoldLettuce();
        }
        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {
            wrap.HoldCheese();
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
