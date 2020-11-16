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
    /// A class representing an order of  Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drinks
    {

        private string description = "Fair trade, fresh ground dark roast coffee.";

        public override String Description
        {
            get => description;
        }

        public override event PropertyChangedEventHandler PropertyChanged;
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
                OnPropertyChanged("Ice");
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
                OnPropertyChanged("Cream");
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
                OnPropertyChanged("Decaf");
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (!decaf)
            {
                sb.Append($"{Size} Candlehearth Coffee \n");
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
            else {
                sb.Append($"{Size} Decaf Candlehearth Coffee \n");
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
        }

        /// <summary>
        /// the name of the item
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return ("Candlehearth Coffee");
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
