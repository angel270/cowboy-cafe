using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A description of a double burger
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// Special Instructions for the sandwich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ketchup)
                    instructions.Add("hold ketchup");
                if (!bun)
                    instructions.Add("hold bun");
                if (!mustard)
                    instructions.Add("hold mustard");
                if (!pickle)
                    instructions.Add("hold pickle");
                if (!cheese)
                    instructions.Add("hold cheese");
                if (!tomato)
                    instructions.Add("hold tomato");
                if (!lettuce)
                    instructions.Add("hold lettuce");
                if (!mayo)
                    instructions.Add("hold mayo");

                return instructions;
            }
        }

        /// <summary>
        /// Price of a double burger
        /// </summary>
        public override double Price
        {
            get { return 5.2; }
        }

        /// <summary>
        /// Calories in a double burger
        /// </summary>
        public override uint Calories
        {
            get { return 464; }
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

        private bool tomato = true;
        /// <summary>
        /// If the customer does not want tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                PropertiesChanged("Tomato");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the customer does not want lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                PropertiesChanged("Lettuce");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If the customer does not want mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                PropertiesChanged("Mayo");
                PropertiesChanged("SpecialInstructions");
            }
        }

        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
