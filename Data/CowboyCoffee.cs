using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        private bool roomForCream = false;
        /// <summary>
        /// If there should be room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                PropertiesChanged("RoomForCream");
                PropertiesChanged("SpecialInstructions");
            }
        }
        private bool decaf = false;
        /// <summary>
        /// If the coffee is caffinated 
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                PropertiesChanged("Decaf");
                PropertiesChanged("SpecialInstructions");
            }
        }
        private bool ice = false;
        /// <summary>
        /// If the coffee is iced
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertiesChanged("Ice");
                PropertiesChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// The price of a coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.6;
                    case Size.Medium:
                        return 1.1;
                    case Size.Small:
                        return 0.6;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// The calories in a coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// The special instructions for a coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice)
                    instructions.Add("Add Ice");
                if (RoomForCream)
                    instructions.Add("Room for Cream");
                if (Decaf)
                    instructions.Add("Make it decaf");

                return instructions;
            }
        }

        public override string GetName
        {
            get { return "Cowboy Coffee"; } 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size);
            if (Decaf)
                sb.Append(" Decaf");
            sb.Append(" Cowboy Coffee");
            return sb.ToString();
        }
    }
}
