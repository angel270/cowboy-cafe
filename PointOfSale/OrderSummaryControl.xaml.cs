 using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }
        public void OnDeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    if(button.DataContext is IOrderItem isItem)
                        data.Remove(isItem);
                }
            }
        }

        public void ChangeExistingItem (object sender, SelectionChangedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();
            if (ancestor == null)
                return;

            foreach(object i in e.AddedItems)
            {
                if (i is AngryChicken)
                {
                    var screen = new AngryChickenCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is CowboyCoffee)
                {
                    var screen = new CowboyCoffeCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is CowpokeChili)
                {
                    var screen = new CowpokeChiliCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is DakotaDoubleBurger)
                {
                    var screen = new DakotaDoubleCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is JerkedSoda)
                {
                    var screen = new JerkedSodaCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is PecosPulledPork)
                {
                    var screen = new PecosPulledPorkCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is PanDeCampo || i is BakedBeans || i is ChiliCheeseFries || i is CornDodgers)
                {
                    var screen = new SideCustomizations();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is CowpokeChili)
                {
                    var screen = new CowpokeChiliCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is TexasTea)
                {
                    var screen = new TexasTeaCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is TexasTripleBurger)
                {
                    var screen = new TexasTripleCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is TrailBurger)
                {
                    var screen = new TrailBurgerCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else if (i is Water)
                {
                    var screen = new WaterCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
            }
        }
    }
}
