/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Side option available on the menu
*/


using BleakwindBuffet.Data.Enums;
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing an order of Fried Miraak
    /// </summary>
    public class FriedMiraak : Side
    {
        /// <summary>
        /// gets the prices of the various sizes
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
        public override double Price
        {
            get
            {
                if (Size.Equals(Size.Small)) { return 1.78; } // small
                if (Size.Equals(Size.Medium)) { return 2.01; } // medium
                if (Size.Equals(Size.Large))   {return 2.88;} // large
                else {throw new NotImplementedException($"Unknown size {Size}"); }
            }
        }

        /// <summary>
        /// gets the calories in the various sizes, if the size is unrecognizes  
        /// it returns an error.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
        public override uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small)) { return 151; } // small
                if (Size.Equals(Size.Medium)) { return 236; } // medium
                if (Size.Equals(Size.Large))   {return 306;} // large
                else {throw new NotImplementedException($"Unknown size {Size}"); }
            }
        }
/* 
         private vriable of the list of special instructions 
        */
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Public method to return the list of instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /* 
        private variable that holds the size 
        */
        private Size OrderSize = Size.Small;
     
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            return ($"{Size} Fried Miraak");
        }
    }
}
