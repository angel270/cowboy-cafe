using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Handles the property changes
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// The size of a drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
        /// <summary>
        /// The price of a drink
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// The calories in a drink
        /// </summary>
        public abstract uint Calories { get; }
        private bool ice = true;
        /// <summary>
        /// If there is ice in a drink
        /// </summary>
        public virtual bool Ice { 
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public abstract string GetName { get; }

        /// <summary>
        /// If there are any special instructions for a drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        protected void PropertiesChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
