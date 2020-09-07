/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Side option available on the menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing an order of DragonBorn Waffle Fries 
    /// </summary>   
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// gets the prices of the various sizes
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
        public double Price 
        {
            get
            {
                if (OrderSize.Equals(Size.Small)) { return .42; } // small
                if (OrderSize.Equals(Size.Medium)) { return .76; } // medium
                if (OrderSize.Equals(Size.Large))   {return .96;} // large
                else {throw new NotImplementedException($"Unknown size {OrderSize}"); }
            }
        }

        /// <summary>
        /// gets the calories in the various sizes, if the size is unrecognizes  
        /// it returns an error.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
        public uint Calories
        {
            get
            {
                if (OrderSize.Equals(Size.Small)) { return 77; } // small
                if (OrderSize.Equals(Size.Medium)) { return 89; } // medium
                if (OrderSize.Equals(Size.Large))   {return 100;} // large
                else {throw new NotImplementedException($"Unknown size {OrderSize}"); }
            }
        }
        /* 
         private vriable of the list of special instructions 
        */
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Public method to return the list of instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /* 
        private variable that holds the size 
        */
        private Enum OrderSize = Size.Small;
        /// <summary>
        /// Public method to return or set the size of the item
        /// </summary>
        public Enum orderSize
        {
            get { return OrderSize; }
            set
            {
                OrderSize = value;
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            return ($"{OrderSize} Dragonborn Waffle Fries");
        }
    }
}
