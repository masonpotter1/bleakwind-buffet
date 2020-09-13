/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Drink option available 
*/

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
        /// <summary>
        /// A class representing an order of Markarth Milk 
        /// </summary>
{
    public class MarkarthMilk : Drinks

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
                if (Size.Equals(Size.Small)) { return 1.05; } // small
                if (Size.Equals(Size.Medium)) { return 1.11; } // medium
                if (Size.Equals(Size.Large))   {return 1.22;} // large
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
                if (Size.Equals(Size.Small)) { return 56; } // small
                if (Size.Equals(Size.Medium)) { return 72; } // medium
                if (Size.Equals(Size.Large))   {return 93;} // large
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
         * Private bool that is set to false by default
         */
        private bool Ice = false;
        /// <summary>
        /// Public method to return or set the bool "Ice" 
        /// if true, Special instruction is to "Add ice'
        /// </summary>
        public bool ice
        {
            get { return Ice; }
            set
            {
                if (!value) specialInstructions.Add("Add ice");
                else { specialInstructions.Remove("Add ice"); }
                Ice = value;
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            return ($"{Size} Markarth Milk");
        }
    }
}
