using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 0;
        private List<IOrderItem> items = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Items => items;
        public double Subtotal
        {
            get
            {
                double total = 0.0;
                foreach (IOrderItem i in items)
                {
                    total += i.Price;
                }
                return total;
            }
        }
        public uint OrderNumber { get; } = lastOrderNumber++;
        public event PropertyChangedEventHandler PropertyChanged;
        
        public void Add(IOrderItem item)
        {
            items?.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        public void Remove(IOrderItem item)
        {
            items?.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

    }
}
