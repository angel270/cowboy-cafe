using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// Gets or sets if the entree has special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// The price of Rustler's Ribs
        /// </summary>
        public override double Price
        {
            get { return 7.5; }
        }

        /// <summary>
        /// The calories in the ribs
        /// </summary>
        public override uint Calories
        {
            get { return 894; }
        }
    }
}
