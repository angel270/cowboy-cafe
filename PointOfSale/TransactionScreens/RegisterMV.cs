using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace PointOfSale.TransactionScreens
{
    public class RegisterMV : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of properties changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer this class uses
        /// </summary>
        private CashDrawer drawer = new CashDrawer();

        private double Paid;

        /// <summary>
        /// Current total in the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        public int Pennies
        {
            get => drawer.Pennies;
            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    Paid += 0.01;
                }
                else
                { 
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                }
            InvokePropertyChanged("Pennies"); 

            }
        }

        public int Nickels
        {
            get => drawer.Nickels;
            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                    Paid += 0.05;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                }
            InvokePropertyChanged("Nickels");

            }
        }

        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantity);
                    Paid += 0.1;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                }
                InvokePropertyChanged("Dimes");

            }
        }

        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quantity);
                    Paid += 0.25;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                }
                InvokePropertyChanged("Quarters");

            }
        }

        public int HalfDollars
        {
            get => drawer.HalfDollars;
            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                    Paid += 0.5;
                }
                else
                {
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                }

                InvokePropertyChanged("HalfDollars");

            }
        }

        public int Dollars
        {
            get => drawer.Dollars;
            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dollar, quantity);
                    Paid += 1;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                }
                InvokePropertyChanged("Dollars");

            }
        }

        public int Ones
        {
            get => drawer.Dollars;
            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0) 
                {
                    drawer.AddBill(Bills.One, quantity);
                    Paid += 1;
                }
                else {
                    drawer.RemoveBill(Bills.One, -quantity);
                }
                InvokePropertyChanged("Ones");

            }
        }

        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Five, quantity);
                    Paid += 5;
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                }
                InvokePropertyChanged("Fives");

            }
        }

        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0) 
                {
                    drawer.AddBill(Bills.Ten, quantity);
                    Paid += 10;
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                }
                InvokePropertyChanged("Tens");

            }
        }

        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantity);
                    Paid += 20;
                }
                else 
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                }
                InvokePropertyChanged("Twenties");

            }
        }

        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0) 
                {
                    drawer.AddBill(Bills.Fifty, quantity);
                    Paid += 50;
                }
                else 
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                }
                InvokePropertyChanged("Fifties");

            }
        }

        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantity);
                    Paid += 100;
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                }
                InvokePropertyChanged("Hundreds");

            }
        }

        public void InvokePropertyChanged(string denom)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denom));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid"));
        }

    }
}
