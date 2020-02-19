using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The flavor of a soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }
        /// <summary>
        /// The price of a soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.1;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// The calories in a soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// The special instructions for a soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice)
                    instructions.Add("Hold Ice");

                return instructions;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Size);
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    sb.Append(" Cream Soda");
                    break;
                case SodaFlavor.OrangeSoda:
                    sb.Append(" Orange Soda");
                    break;
                case SodaFlavor.Sarsparilla:
                    sb.Append(" Sarsparilla");
                    break;
                case SodaFlavor.BirchBeer:
                    sb.Append(" Birch Beer");
                    break;
                case SodaFlavor.RootBeer:
                    sb.Append(" Root Beer");
                    break;
            }
            sb.Append(" Jerked Soda");
            return sb.ToString();
        }
    }
}
