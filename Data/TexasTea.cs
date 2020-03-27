using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// If this is sweet tea, which it is by default
        /// </summary>
        private bool sweet = true;
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                PropertiesChanged("Sweet");
                PropertiesChanged("SpecialInstructions");
            }
        }
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
                PropertiesChanged("Lemon");
                PropertiesChanged("SpecialInstructions");
            }
        }
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
