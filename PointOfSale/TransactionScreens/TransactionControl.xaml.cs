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
using CashRegister;
using PointOfSale.ExtensionMethods;

namespace PointOfSale.TransactionScreens
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        private ReceiptPrinter printer = new ReceiptPrinter();

        public TransactionControl()
        {
            InitializeComponent();
        }

        private void CardPayment(object sender, RoutedEventArgs e)
        {
            CCContainer.Child = new CardControl();
        }

        private void CashPayment(object sender, RoutedEventArgs e)
        {
            CCContainer.Child = new RegisterControl();
        }

        private void CancelTransaction(object sender, RoutedEventArgs e)
        {
            var control = this.FindAncestor<OrderControl>();
            var screen = new MenuItemSelectionControl();
            control.SwapScreen(screen);
        }
        public void SwapScreen(FrameworkElement element)
        {
            CCContainer.Child = element;
        }
    }
}
