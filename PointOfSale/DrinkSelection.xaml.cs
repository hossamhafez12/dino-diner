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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Drink drink;
        public DrinkSelection()
        {
            InitializeComponent();
        }
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (drink == null) { return; }
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
        void SelectFlavor(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
        private void OnSelectSodassaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
            }
        }
        private void OnSelectTryannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
            }
        }
        private void OnSelectJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
            }
        }
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
        }
    }
}
