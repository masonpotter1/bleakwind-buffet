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
    /// A class representing an order of  Sailor's Spda
    /// </summary>
    public class SailorSoda
    {
        /// <summary>
        /// gets the prices of the various sizes
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
        public double Price
        {
            get {
                if (cupSize.Equals(Size.Small)) { return 1.42; } // small
                if (cupSize.Equals(Size.Medium)) { return 1.74; } // medium
                if (cupSize.Equals(Size.Large))   {return 2.07;} // large
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
                if (cupSize.Equals(Size.Small)) { return 117; } // small
                if (cupSize.Equals(Size.Medium)) { return 153; } // medium
                if (cupSize.Equals(Size.Large))   {return 205;} // large
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
         * Private bool that is set to True by default
         */
        private bool Ice = true;
        /// <summary>
        /// Public method to return or set the bool "Ice" 
        /// if False, Special instruction is to "Hold ice'
        /// </summary>
        public bool ice
        {
            get { return Ice; }
            set
            {
                if (!value) specialInstructions.Add("Hold ice");
                else { specialInstructions.Remove("Hold ice"); }
                Ice = value;
            }
        }
        /*
         * Private bool that represents the flavor of the soda. By default, it
         * is set to the "Cherry" flavor.
         */
        private Enum Flavor = SodaFlavor.Cherry;
         /// <summary>
        /// Public method to return or set the flavor of the soda 
        /// Flavor options can be found in the "Enums" file, SodaFlavor.cs
        /// </summary>
        public Enum flavor
        {
            get { return Flavor; }
            set
            {
                Flavor = value;
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            return ($"{CupSize} {flavor} Sailor Soda");
        }

    }
}
