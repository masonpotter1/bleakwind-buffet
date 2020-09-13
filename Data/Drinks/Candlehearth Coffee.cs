/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Drink option available 
*/

using BleakwindBuffet.Data.Enums;
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing an order of  Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drinks
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
                if (Size.Equals(Size.Small)) { return .75; } // small
                if (Size.Equals(Size.Medium)) { return 1.25; } // medium
                if (Size.Equals(Size.Large))   {return 1.75;} // large
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
                if (Size.Equals(Size.Small)) { return 7; } // small
                if (Size.Equals(Size.Medium)) { return 10; } // medium
                if (Size.Equals(Size.Large))   {return 20;} // large
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
        /*
         * Private bool that is set to false by default
         */
        private bool RoomForCream = false;
        /// <summary>
        /// Public method to return or set the bool "RoomForCream" 
        /// if true, Special instruction is to "Add cream'
        /// </summary>
        public bool roomForCream
        {
            get { return RoomForCream; }
            set
            {
                if (!value) specialInstructions.Add("Add cream");
                else { specialInstructions.Remove("Add cream"); }
                RoomForCream = value;
            }
        }
        /*
         * Private bool that is set to false by default
         */
        private bool Decaf = false;
        /// <summary>
        /// Public method to return or set the bool "Decaf" 
        /// if true, Special instruction is updated to "Decaf'
        /// </summary>
        public bool decaf
        {
            get { return Decaf; }
            set
            {
                if (!value) specialInstructions.Add("Decaf ");
                else { specialInstructions.Remove("Decaf "); }
                Decaf = value;
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            if (!decaf)
            {
                return ($"{Size} Candlehearth Coffee");
            }
            else { return ($"{Size} Decaf Candlehearth Coffee"); }
        }

    }
}
