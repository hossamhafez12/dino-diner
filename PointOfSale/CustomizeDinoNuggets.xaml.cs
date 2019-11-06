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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        private DinoNuggets nug;
        private CretaceousCombo combo;

        public CustomizeDinoNuggets(DinoNuggets nuggets)
        {
            InitializeComponent();
            this.nug = nuggets;
        }
        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.nug = (DinoNuggets)combo.Entree;
            this.combo = combo;
        }
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            nug.AddNugget();
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
