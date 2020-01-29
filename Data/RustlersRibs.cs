using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs
    {
        /// <summary>
        /// The price of Rustler's Ribs
        /// </summary>
        public double Price
        {
            get { return 7.5; }
        }

        /// <summary>
        /// The calories in the ribs
        /// </summary>
        public uint Calories
        {
            get { return 894; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                return null;
            }
        }
    }
}
