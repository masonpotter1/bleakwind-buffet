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
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing an order of  Sailor's Spda
    /// </summary>
    public class SailorSoda : Drinks
    {
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets the prices of the various sizes
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
        public override double Price
        {
            get {
                if (Size.Equals(Size.Small)) { return 1.42; } // small
                if (Size.Equals(Size.Medium)) { return 1.74; } // medium
                if (Size.Equals(Size.Large))   {return 2.07;} // large
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
                if (Size.Equals(Size.Small)) { return 117; } // small
                if (Size.Equals(Size.Medium)) { return 153; } // medium
                if (Size.Equals(Size.Large))   {return 205;} // large
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
        private variable that holds the size of the drink
        */
      


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
                OnPropertyChanged("Hold Ice");
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
                OnPropertyChanged(flavor.ToString());
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Size} {flavor} Sailor Soda \n");
            for (int i = 0; i < specialInstructions.Count; i++)
            {
                sb.Append(" -");
                sb.Append(specialInstructions[i]);
                sb.Append("\n");
            }
            sb.Append($"                                                                         ${Price}");

            string final = sb.ToString();
            return (final);
        }

        /// <summary>
        /// The Property that was changes - creates a new changed event.
        /// </summary>
        /// <param name="name"></param>
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
    }
}
