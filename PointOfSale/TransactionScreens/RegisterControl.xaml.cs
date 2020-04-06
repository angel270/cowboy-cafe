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
using CashRegister;
using PointOfSale.ExtensionMethods;
using CowboyCafe.Data;

namespace PointOfSale.TransactionScreens
{
    /// <summary>
    /// Interaction logic for RegisterControl.xaml
    /// </summary>
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();
            if(DataContext is Order data)
            {
                var oc = this.FindAncestor<OrderControl>();
                var register = new RegisterMV();
                var printer = new ReceiptPrinter();
                    oc.SwapScreen(new OrderControl());
                    oc.DataContext = new Order();
                    printer.Print(CreateReceipt(data));
            }
        }

        private string CreateReceipt(Order data)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order NO: " + data.OrderNumber + "\n");
            sb.Append("Time: " + DateTime.Now.ToString() + "\n");
            sb.Append("***********************************************************\n");
            foreach (var i in data.Items)
            {
                sb.Append(i.ToString() + "\t\t");
                sb.Append(i.Price + "\n" + "\t");
                for (int x = 0; x < i.SpecialInstructions.Count; x++)
                {
                    sb.Append(i.SpecialInstructions[x].ToString() + "\n" + "\t");
                }
            }
            sb.Append("***********************************************************\n");
            sb.Append("\nSubtotal:\t\t$" + data.Subtotal + "\n");
            sb.Append("Tax:\t\t\t$" + (data.Subtotal * 0.16) + "\n");
            sb.Append("Total:\t\t\t$" + data.Total + "\n");
            sb.Append("***********************************************************\n");
            //            sb.Append("Paid:\t\t$" + data.Paid + "\n");
            //            sb.Append("Change:\t\t$" + data.Change);
            sb.Append("***********************************************************\n");

            return sb.ToString();
        }
    }
}
