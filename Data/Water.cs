using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// If this should be a lemon water
        /// </summary>
        public bool Lemon { get; set; } = false;
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
    }
}
