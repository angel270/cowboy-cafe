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
        /// <summary>
        /// The size of a drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;
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
        /// <summary>
        /// If there are any special instructions for a drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
