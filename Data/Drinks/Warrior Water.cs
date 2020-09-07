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
    /// A class representing an order of Warrior Water
    /// </summary>
    public class WarriorWater
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
                if (cupSize.Equals(Size.Small)) { return 0; } // small
                if (cupSize.Equals(Size.Medium)) { return 0; } // medium
                if (cupSize.Equals(Size.Large)) { return 0;} // large
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
                if (cupSize.Equals(Size.Small)) { return 0; } // small
                if (cupSize.Equals(Size.Medium)) { return 0; } // medium
                if (cupSize.Equals(Size.Large)) { return 0; } // large
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
         * Private bool that is set to false by default - represents if 
         * Lemon is added to the water
         */
        private bool Lemon = false;
        /// <summary>
        /// Public method to return or set the bool "Lemon" 
        /// if True, Special instruction is to "Add Lemon"
        /// </summary>
        public bool lemon
        {
            get { return Lemon; }
            set
            {
                if (!value) specialInstructions.Add("Add lemon");
                else { specialInstructions.Remove("Add lemon"); }
                Lemon = value;
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            return ($"{CupSize} Warrior Water");
        }
    }
}
