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
    /// Interaction logic for CardControl.xaml
    /// </summary>
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
            if(DataContext is Order data) 
            {
                var oc = this.FindAncestor<OrderControl>();
                var reader = new CardTerminal();
                var result = reader.ProcessTransaction(data.Total);
                var printer = new ReceiptPrinter();
                switch (result)
                {
                    case ResultCode.Success:
                        CardDisplay.Text = "Success.";
                        printer.Print(CreateReceipt(data));
                        oc.SwapScreen(new OrderControl());
                        oc.DataContext = new Order();
                        break;
                    case ResultCode.CancelledCard:
                    case ResultCode.InsufficentFunds:
                    case ResultCode.ReadError:
                    case ResultCode.UnknownErrror:
                        CardDisplay.Text = result.ToString();
                        var control = this.FindAncestor<TransactionControl>();
                        control.SwapScreen(new TransactionControl());
                        break;
                }
            }
            
        }

        private string CreateReceipt(Order data)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order NO: " + data.OrderNumber + "\n");
            sb.Append("Time: " + DateTime.Now.ToString() + "\n");

            foreach(var i in data.Items)
            {
                sb.Append(i.ToString() + "\t\t");
                sb.Append(i.Price + "\n" + "\t");
                for(int x = 0; x < i.SpecialInstructions.Count; x++)
                {
                    sb.Append(i.SpecialInstructions[x].ToString() + "\n" + "\t");
                }
            }
            sb.Append("\nSubtotal:\t\t" + data.Subtotal + "\n");
            sb.Append("Tax:\t\t" + (data.Subtotal * 0.16) + "\n");
            sb.Append("Total:\t\t" + data.Total + "\n");
            sb.Append("Credit Card Transaction.");

            return sb.ToString();
        }
    }
}
