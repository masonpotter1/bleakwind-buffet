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
    class SailorSoda
    {
        public double Price
        {
            get {
                if (cupSize.CompareTo(0) == 0) { return 1.42; } // small
                if (cupSize.CompareTo(1) == 0) { return 1.74; } // medium
                else { return 2.07; } // large
            }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (cupSize.CompareTo(0) == 0) { return 117; } // small
                if (cupSize.CompareTo(1) == 0) { return 153; } // medium
                else { return 205; } // large
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

        private bool Ice = true;
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

        private Enum Flavor = SodaFlavor.Cherry;
        public Enum flavor
        {
            get { return Flavor; }
            set
            {
                Flavor = value;
            }
        }

        public override string ToString()
        {
            return ($"{CupSize}{flavor} Sailor Soda");
        }

    }
}
