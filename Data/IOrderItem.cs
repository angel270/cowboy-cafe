using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        public List<string> SpecialInstructions { get; }
        public double Price { get; }
    }
}
