using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Keeps track of the order number next available
        /// </summary>
        private static uint lastOrderNumber = 0;
        /// <summary>
        /// A private backing field of items in an order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// A property that returns the items in an order
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();
        /// <summary>
        /// Returns the subtotal of an order
        /// </summary>
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

        public double Total { get { return Subtotal * 1.16; } }

        public double Paid = 0.0;

        public double Change => Total - Paid;

        /// <summary>
        /// Updates the order number for current order
        /// </summary>
        public uint OrderNumber { get; } = lastOrderNumber++;
        /// <summary>
        /// Handles property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Adds an item to an order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items?.Add(item);
            if(item is INotifyPropertyChanged pcitem)
                pcitem.PropertyChanged += OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }
        /// <summary>
        /// Removes an item from an order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items?.Remove(item);
            if (item is INotifyPropertyChanged pcitem)
                pcitem.PropertyChanged -= OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }
        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
        }
    }
}
