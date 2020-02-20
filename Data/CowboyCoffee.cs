using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// If there should be room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        /// <summary>
        /// If the coffee is caffinated 
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// If the coffee is iced
        /// </summary>
        public override bool Ice { get; set; } = false;
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
