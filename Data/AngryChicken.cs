using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree
    {
        /// <summary>
        /// Handles the property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Special Instructions for the sandwich
        /// </summary>
        public override List<string> SpecialInstructions
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

        /// <summary>
        /// The price of the chicken sandwich
        /// </summary>
        public override double Price
        {
            get { return 5.99; }
        }

        /// <summary>
        /// Calories in the chicken sandwich
        /// </summary>
        public override uint Calories
        {
            get { return 190; }
        }

        private bool bread = true;
        /// <summary>
        /// If the customer wants bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the customer wants pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
