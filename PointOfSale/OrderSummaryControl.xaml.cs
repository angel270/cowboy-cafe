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
                if (i is CowpokeChili)
                {
                    var screen = new CowpokeChiliCustomization();
                    screen.DataContext = i;
                    ancestor.SwapScreen(screen);
                }
                else
                {

                }
            }
        }
    }
}
