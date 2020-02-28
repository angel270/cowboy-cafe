using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private uint lastOrderNumber;
        public event PropertyChangedEventHandler PropertyChanged;
        public double Subtotal => 0;
        public uint OrderNumber { get; }
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public void Add(IOrderItem item)
        {

        }

        public void Remove(IOrderItem item)
        {

        }

    }
}
