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
        private OrderControl oc;

        public CardControl(Order data, OrderControl control)
        {
            this.DataContext = data;
            InitializeComponent();

            var reader = new CardTerminal();
            var printer = new ReceiptPrinter();
            var result = reader.ProcessTransaction(data.Total);

            switch (result)
            {
                case ResultCode.Success:
                    CardDisplay.Text = "Success.";
                    printer.Print(CreateReceipt(data));
                    oc.SwapScreen();
                    break;

                case ResultCode.CancelledCard:
                case ResultCode.InsufficentFunds:
                case ResultCode.ReadError:
                case ResultCode.UnknownErrror:
                    CardDisplay.Text = result.ToString();
                    break;   
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
                sb.Append(i.ToString() + "");
                sb.Append(i.Price + "\n");
                if(i.SpecialInstructions != null)
                {
                    for (int x = 0; x < i.SpecialInstructions.Count; x++)
                    {
                        sb.Append("\t" + i.SpecialInstructions[x].ToString() + "\n");
                    }
                }
            }
            sb.Append("**********************************************************\n");
            sb.Append("Subtotal:\t\t" + data.Subtotal + "\n");
            sb.Append("Tax:\t\t\t" + (data.Subtotal * 0.16) + "\n");
            sb.Append("Total:\t\t\t" + data.Total + "\n");
            sb.Append("Credit Card Transaction.\n");
            sb.Append("***********************************************************\n");
            return sb.ToString();
        }
    }
}
