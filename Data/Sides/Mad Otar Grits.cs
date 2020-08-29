/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Side option available on the menu
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    class Mad_Otar_Grits
    {
        public double Price
        {
            get
            {
                if (OrderSize.CompareTo(0) == 0) { return 1.22; } // small
                if (OrderSize.CompareTo(1) == 0) { return 1.58; } // medium
                else { return 1.93; } // large
            }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (OrderSize.CompareTo(0) == 0) { return 105; } // small
                if (OrderSize.CompareTo(1) == 0) { return 142; } // medium
                else { return 179; } // large
            }
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        private Enum OrderSize = Size.Small;
        public Enum orderSize
        {
            get { return OrderSize; }
            set
            {
                OrderSize = value;
            }
        }

        public override string ToString()
        {
            return ($"{OrderSize} Dragonborn Waffle Fries");
        }
    }
}
