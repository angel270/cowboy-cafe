﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A description of the Peco's Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {
        /// <summary>
        /// Price of a pulled pork sandwich
        /// </summary>
        public double Price
        {
            get { return 5.88; }
        }

        /// <summary>
        /// Calories in a pulled pork sandwich
        /// </summary>
        public uint Calories
        {
            get { return 528; }
        }

        private bool bread = true;
        /// <summary>
        /// If the customer wants bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the customer wants pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Special Instructions for the sandwich
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread)
                    instructions.Add("hold bread");
                if (!pickle)
                    instructions.Add("hold pickle");

                return instructions;
            }
        }

    }
}
