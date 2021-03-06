﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A description of a triple burger
    /// </summary>
    public class TexasTripleBurger : Entree
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
                if (!tomato)
                    instructions.Add("hold tomato");
                if (!lettuce)
                    instructions.Add("hold lettuce");
                if (!mayo)
                    instructions.Add("hold mayo");
                if (!bacon)
                    instructions.Add("hold bacon");
                if (!egg)
                    instructions.Add("hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Price of a double burger
        /// </summary>
        public override double Price
        {
            get { return 6.45; }
        }

        /// <summary>
        /// Calories in a double burger
        /// </summary>
        public override uint Calories
        {
            get { return 698; }
        }
        
        private bool bun = true;
        /// <summary>
        /// If the customer does not want buns
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value;
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
            set { ketchup = value;
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
            set { mustard = value;
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
            set { pickle = value;
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
            set { cheese = value;
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
            set { tomato = value;
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
            set { lettuce = value;
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
            set { mayo = value;
                PropertiesChanged("Mayo");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool bacon = true;
        /// <summary>
        /// If the customer does not want bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value;
                PropertiesChanged("Bacon");
                PropertiesChanged("SpecialInstructions");
            }
        }

        private bool egg = true;
        /// <summary>
        /// If the customer does not want egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value;
                PropertiesChanged("Egg");
                PropertiesChanged("SpecialInstructions");
            }
        }

        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
