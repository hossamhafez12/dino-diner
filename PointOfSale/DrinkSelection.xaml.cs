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
        private CretaceousCombo combo;
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
        private void SelectFlavor(object sender, RoutedEventArgs args)
        {
            if(drink is Sodasaurus)
            {
                NavigationService.Navigate(new FlavorSelection((Sodasaurus)drink));
            }
        }
        private void OnLemon(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if(drink is Water water)
                    {
                        water.AddLemon();
                    }
                    if(drink is Tyrannotea tea)
                    {
                        tea.AddLemon();
                    }
                }
            }
        }
        private void OnDecaf(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is JurassicJava java)
                    {
                        java.IsDecaf();
                    }
                }
            }
        }
        private void OnIce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is JurassicJava java)
                    {
                        java.AddIce();
                    }
                    if(drink is Sodasaurus soda)
                    {
                        soda.HoldIce();
                    }
                    if (drink is Tyrannotea tea)
                    {
                        tea.AddIce();
                    }
                    if (drink is Water water)
                    {
                        water.HoldIce();
                    }
                }
            }
        }
        private void OnSweet(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Tyrannotea tea)
                    {
                        tea.IsSweet();
                    }    
                }
            }
        }
        private void OnSelectSodassaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                if ((bool)MakeSmall.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
                if ((bool)MakeMedium.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
                if ((bool)MakeLarge.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
                order.Add(drink);
                Decaf.IsEnabled = false;
                Sweet.IsEnabled = false;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
                Flavor.IsEnabled = true;

            }
        }
        private void OnSelectTryannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                if ((bool)MakeSmall.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
                if ((bool)MakeMedium.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
                if ((bool)MakeLarge.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
                order.Add(drink);
                Decaf.IsEnabled = false;
                Sweet.IsEnabled = true;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
                Flavor.IsEnabled = false;
            }
        }
        private void OnSelectJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                if ((bool)MakeSmall.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
                if ((bool)MakeMedium.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
                if ((bool)MakeLarge.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
                order.Add(drink);
                Decaf.IsEnabled = true;
                Sweet.IsEnabled = false;
                Lemon.IsEnabled = false;
                Ice.IsEnabled = true;
                Flavor.IsEnabled = false;
            }
        }
        private void OnSelectWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                if ((bool)MakeSmall.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }
                if ((bool)MakeMedium.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
                if ((bool)MakeLarge.IsChecked)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
                order.Add(drink);
                Decaf.IsEnabled = false;
                Sweet.IsEnabled = false;
                Lemon.IsEnabled = true;
                Ice.IsEnabled = true;
                Flavor.IsEnabled = false;
            }
        }
    }
}
