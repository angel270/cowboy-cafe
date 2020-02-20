using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// If this is sweet tea, which it is by default
        /// </summary>
        public bool Sweet { get; set; } = true;
        /// <summary>
        /// If there is lemon in the tea,
        /// which is false by default
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// The price of a Texas tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.0;
                    case Size.Medium:
                        return 1.5;
                    case Size.Small:
                        return 1.0;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// The calories in a texas tea based on
        /// if it is sweet or not
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(Sweet)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }
            }
        }
        /// <summary>
        /// The special instructions for a sweet tea
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
            
            sb.Append(" Texas");
            if (!Sweet)
                sb.Append(" Plain");
            else
                sb.Append(" Sweet");
            sb.Append(" Tea");
            return sb.ToString();
        }
    }
}
