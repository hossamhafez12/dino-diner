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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;
        private CretaceousCombo combo;
        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                side = new Fryceritops();
                if ((bool)MakeSmall.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
                if ((bool)MakeMedium.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
                if ((bool)MakeLarge.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
                order.Add(side);
            }
        }
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                if ((bool)MakeSmall.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
                if ((bool)MakeMedium.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
                if ((bool)MakeLarge.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
                order.Add(side);
            }
        }
        private void OnSelectMeteor(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                if ((bool)MakeSmall.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
                if ((bool)MakeMedium.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
                if ((bool)MakeLarge.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
                order.Add(side);
            }
        }
        private void OnSelectMozzerellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                if ((bool)MakeSmall.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
                if ((bool)MakeMedium.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
                if ((bool)MakeLarge.IsChecked)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
                order.Add(side);
            }
        }
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (side == null) { return; }
            if(sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }



    }
}
