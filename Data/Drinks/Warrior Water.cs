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
    class Warrior_Water
    {
        public double Price
        {
            get
            {
                if (cupSize.CompareTo(0) == 0) { return 0; } // small
                if (cupSize.CompareTo(1) == 0) { return 0; } // medium
                else { return 0; } // large
            }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (cupSize.CompareTo(0) == 0) { return 0; } // small
                if (cupSize.CompareTo(1) == 0) { return 0; } // medium
                else { return 0; } // large
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
        private bool Lemon = false;
        public bool lemon
        {
            get { return Lemon; }
            set
            {
                if (!value) specialInstructions.Add("Add lemon");
                else { specialInstructions.Remove("Add lemon"); }
                Lemon = value;
            }
        }

        public override string ToString()
        {
            return ($"{CupSize} Warrior Wate");
        }
    }
}
