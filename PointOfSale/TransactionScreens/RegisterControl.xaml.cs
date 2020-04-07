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
            if(DataContext is RegisterMV data)
            {
                var printer = new ReceiptPrinter();
                var oc = this.FindAncestor<OrderControl>();
                if(oc.DataContext is Order order)
                {
                    if (data.Paid >= order.Total)
                        printer.Print(CreateCashReceipt(order, data.drawer));
                } 
            }
        }

        /// <summary>
        /// Creates a receipt
        /// </summary>
        /// <param name="data">The order being billed.</param>
        /// <param name="register">The amount being handled</param>
        /// <returns>A receipt.</returns>
        private string CreateCashReceipt(Order data, CashDrawer register)
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
            sb.Append("Paid:\t\t\t" + register.Paid);
            sb.Append("Change:\t\t\t" + register.Change);
            sb.Append("****************************\n");
            return sb.ToString();
        }

    }
}
