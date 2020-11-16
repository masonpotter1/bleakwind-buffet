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
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing an order of DragonBorn Waffle Fries 
    /// </summary>   
    public class DragonbornWaffleFries : Side
    {
        /// <summary>
        /// Description of the item
        /// </summary>
        /// <returns></returns>
        private string description = "Crispy fried potato waffle fries.";

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
                if (Size.Equals(Size.Small)) { return .42; } // small
                if (Size.Equals(Size.Medium)) { return .76; } // medium
                if (Size.Equals(Size.Large))   {return .96;} // large
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
                if (Size.Equals(Size.Small)) { return 77; } // small
                if (Size.Equals(Size.Medium)) { return 89; } // medium
                if (Size.Equals(Size.Large))   {return 100;} // large
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
        public override  List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /* 
        private variable that holds the size 
        */
        private Size OrderSize = Size.Small;


        /// <summary>
        /// the name of the item
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return ("Dragonborn Waffle Fries");
        }

        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Size} Dragonborn Waffle Fries \n");
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
}
