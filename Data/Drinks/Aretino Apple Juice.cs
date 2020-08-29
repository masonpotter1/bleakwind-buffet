using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class Aretino_Apple_Juice
    {
        public double Price
        {
            get
            {
                if (cupSize.CompareTo(0) == 0) { return .62; } // small
                if (cupSize.CompareTo(1) == 0) { return .87; } // medium
                else { return 1.01; } // large
            }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (cupSize.CompareTo(0) == 0) { return 44; } // small
                if (cupSize.CompareTo(1) == 0) { return 88; } // medium
                else { return 132; } // large
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
            return ($"{CupSize} Aretino Apple Juice");
        }
    }
}
