/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Drink option available 
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
        /// <summary>
        /// A class representing an order of Arentino Apple Juice  
        /// </summary>
    public class AretinoAppleJuice
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
                if (cupSize.Equals(Size.Small)) { return .62; } // small
                if (cupSize.Equals(Size.Medium)) { return .87; } // medium
                if (cupSize.Equals(Size.Large))   {return 1.01;} // large
                else {throw new NotImplementedException($"Unknown size {CupSize}"); }
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
                if (cupSize.Equals(Size.Small)) { return 44; } // small
                if (cupSize.Equals(Size.Medium)) { return 88; } // medium
                if (cupSize.Equals(Size.Large))   {return 132;} // large
                else {throw new NotImplementedException($"Unknown size {CupSize}"); }
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
        private variable that holds the size of the drink
        */
        private Enum CupSize = Size.Small;
        /// <summary>
        /// Public method to return or set the size of the Drink
        /// </summary>
        public Enum cupSize
        {
            get { return CupSize; }
            set
            {
                CupSize = value;
            }
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
            return ($"{CupSize} Aretino Apple Juice");
        }
    }
}
