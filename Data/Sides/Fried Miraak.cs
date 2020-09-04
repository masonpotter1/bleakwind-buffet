/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Side option available on the menu
*/


using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    class FriedMiraak
    {
        public double Price
        {
            get
            {
                if (OrderSize.CompareTo(0) == 0) { return 1.78; } // small
                if (OrderSize.CompareTo(1) == 0) { return 2.01; } // medium
                else { return 2.88; } // large
            }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (OrderSize.CompareTo(0) == 0) { return 151; } // small
                if (OrderSize.CompareTo(1) == 0) { return 236; } // medium
                else { return 306; } // large
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
            return ($"{OrderSize} Fried Miraak" +
                $"" +
                $"");
        }
    }
}
