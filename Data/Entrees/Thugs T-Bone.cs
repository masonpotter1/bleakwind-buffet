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

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        public override string ToString()
        {
            return ("Thugs T-Bone");
        }
    }
}
