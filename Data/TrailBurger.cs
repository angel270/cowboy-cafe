using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class TrailBurger : Entree
    {
        /// <summary>
        /// Special Instructions for the sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun)
                    instructions.Add("hold bun");
                if (!ketchup)
                    instructions.Add("hold ketchup");
                if (!mustard)
                    instructions.Add("hold mustard");
                if (!pickle)
                    instructions.Add("hold pickle");
                if (!cheese)
                    instructions.Add("hold cheese");

                return instructions;
            }
        }

        /// <summary>
        /// Price of a burger
        /// </summary>
        public override double Price
        {
            get { return 4.5; }
        }

        /// <summary>
        /// Calories in a burger
        /// </summary>
        public override uint Calories
        {
            get { return 288; }
        }

        private bool bun = true;
        /// <summary>
        /// If the customer does not want buns
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                PropertiesChanged("Bun");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If the customer does not want ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                PropertiesChanged("Ketchup");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the customer does not want mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                PropertiesChanged("Mustard");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the customer does not want pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertiesChanged("Pickle");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If the customer does not want cheese
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

        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
