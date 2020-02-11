using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        /// <summary>
        /// The size of a drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// The price of a drink
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// The calories in a drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// If there is ice in a drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;
        /// <summary>
        /// If there are any special instructions for a drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
