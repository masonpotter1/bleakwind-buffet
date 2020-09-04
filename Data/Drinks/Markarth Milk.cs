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
    class MarkarthMilk
    {
        public double Price
        {
            get
            {
                if (cupSize.CompareTo(0) == 0) { return 1.05; } // small
                if (cupSize.CompareTo(1) == 0) { return 1.11; } // medium
                else { return 1.22; } // large
            }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (cupSize.CompareTo(0) == 0) { return 56; } // small
                if (cupSize.CompareTo(1) == 0) { return 72; } // medium
                else { return 93; } // large
            }
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        private Enum CupSize = Size.Small;
        public Enum cupSize
        {
            get { return CupSize; }
            set
            {
                CupSize = value;
            }
        }

        private bool Ice = false;
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

        public override string ToString()
        {
            return ($"{CupSize} Markarth Milk");
        }
    }
}
