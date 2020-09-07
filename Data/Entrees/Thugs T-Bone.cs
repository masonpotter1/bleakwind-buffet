/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Entree option available on the menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
        /// <summary>
        /// A class representing an order of the Thug's T-Bone 
        /// </summary>
    public class ThugsTBone
    {        /// <summary>
             /// gets the price of the Item
             /// </summary>
        public double Price
        {
            get { return 6.44; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get { return 982; }
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
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            return ("Thugs T-Bone");
        }
    }
}
