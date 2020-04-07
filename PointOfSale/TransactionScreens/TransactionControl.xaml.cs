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
        public TransactionControl()
        {
            InitializeComponent();
        }

        private void CardPayment(object sender, RoutedEventArgs e)
        {
            var oc = this.FindAncestor<OrderControl>();
            if(oc.DataContext is Order order)
            {
                var reader = new CardTerminal();
                var printer = new ReceiptPrinter();
                var result = reader.ProcessTransaction(order.Total);

                switch (result)
                {
                    case ResultCode.Success:
                        Display.Text = "Success.";
                        printer.Print(CreateCardReceipt(order));
                        oc.SwapScreen(new MenuItemSelectionControl());
                        oc.DataContext = new Order();
                        break;

                    case ResultCode.CancelledCard:
                    case ResultCode.InsufficentFunds:
                    case ResultCode.ReadError:
                    case ResultCode.UnknownErrror:
                        string r = result.ToString();
                        Display.Text = r;
                        oc.SwapScreen(new TransactionControl());
                        break;
                }
            }
        }

        private void CashPayment(object sender, RoutedEventArgs e)
        {
            var oc = this.FindAncestor<OrderControl>();
            var register = new RegisterMV();
            oc.DataContext = register;
            oc.SwapScreen(new RegisterControl());
        }

        private void CancelTransaction(object sender, RoutedEventArgs e)
        {
            var oc = this.FindAncestor<OrderControl>();
            oc.SwapScreen(new MenuItemSelectionControl());
        }

        private string CreateCardReceipt(Order data)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("***********************************************************\n");
            sb.Append("Order NO: " + data.OrderNumber + "\n");
            sb.Append("Time: " + DateTime.Now.ToString() + "\n");
            sb.Append("****************************\n");

            foreach (var i in data.Items)
            {
                sb.Append(i.ToString() + "\t\t");
                sb.Append(i.Price + "\n");
                if (i.SpecialInstructions != null)
                {
                    for (int x = 0; x < i.SpecialInstructions.Count; x++)
                    {
                        sb.Append("\t" + i.SpecialInstructions[x].ToString() + "\n");
                    }
                }
            }
            sb.Append("****************************\n");
            sb.Append("Subtotal:\t\t" + data.Subtotal + "\n");
            sb.Append("Tax:\t\t\t" + (data.Subtotal * 0.16) + "\n");
            sb.Append("Total:\t\t\t" + data.Total + "\n");
            sb.Append("Credit Card Transaction.\n");
            sb.Append("****************************\n");
            return sb.ToString();
        }
}
