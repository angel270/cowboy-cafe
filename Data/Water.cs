using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Handles the property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        private bool lemon = false;
        /// <summary>
        /// If this should be a lemon water
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// The price of a water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }
        /// <summary>
        /// The calories in water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }
        /// <summary>
        /// The special instructions for a water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice)
                    instructions.Add("Hold Ice");
                if (Lemon)
                    instructions.Add("Add Lemon");

                return instructions;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size);
            sb.Append(" Water");
            return sb.ToString();
        }
    }
}
