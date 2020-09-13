using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// gets the price of the Item
        /// </summary>
         double Price { get; }
        
        /// <summary>
        /// gets the calories 
        /// </summary>
         uint Calories {get;}
        /// <summary>
        /// Public method to return the list of instructions
        /// </summary>
         List<string> SpecialInstructions { get; }
       
    }
}
