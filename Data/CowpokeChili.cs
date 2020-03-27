using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili : Entree
    {
        /// <summary>
        /// Handles the property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                PropertiesChanged("Cheese");
                PropertiesChanged("SpecialInstructions");

            }
        }

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set 
            { 
                sourCream = value;
                PropertiesChanged("SourCream");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set 
            {
                greenOnions = value;
                PropertiesChanged("GreenOnions");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set 
            {
                tortillaStrips = value;
                PropertiesChanged("TortillaStrips");
                PropertiesChanged("SpecialInstructions");
            }
        }
        public override string ToString()
        {
            return "Cowpoke Chili";
        }
    }
}

