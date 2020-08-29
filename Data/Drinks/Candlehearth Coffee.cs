/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Drink option available 
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class Candlehearth_Coffee
    {
        public double Price
        {
            get
            {
                if (cupSize.CompareTo(0) == 0) { return .75; } // small
                if (cupSize.CompareTo(1) == 0) { return 1.25; } // medium
                else { return 1.75; } // large
            }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (cupSize.CompareTo(0) == 0) { return 7; } // small
                if (cupSize.CompareTo(1) == 0) { return 10; } // medium
                else { return 20; } // large
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

        private bool RoomForCream = false;
        public bool roomForCream
        {
            get { return RoomForCream; }
            set
            {
                if (!value) specialInstructions.Add("Add cream");
                else { specialInstructions.Remove("Add cream"); }
                RoomForCream = value;
            }
        }

        private bool Decaf = false;
        public bool decaf
        {
            get { return Decaf; }
            set
            {
                if (!value) specialInstructions.Add("Decaf ");
                else { specialInstructions.Remove("Decaf "); }
                Decaf = value;
            }
        }
        public override string ToString()
        {
            if (!decaf)
            {
                return ($"{CupSize} Candlehearth Coffee");
            }
            else { return ($"{CupSize} Decaf Candlehearth Coffee"); }
        }

    }
}
