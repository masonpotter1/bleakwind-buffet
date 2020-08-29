using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    class Dragonborn_Waffle_Fries
    {
        public double Price
        {
            get
            {
                if (OrderSize.CompareTo(0) == 0) { return .42; } // small
                if (OrderSize.CompareTo(1) == 0) { return .76; } // medium
                else { return .96; } // large
            }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (OrderSize.CompareTo(0) == 0) { return 77; } // small
                if (OrderSize.CompareTo(1) == 0) { return 89; } // medium
                else { return 100; } // large
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
            return ($"{OrderSize} Warrior Wate");
        }
    }
}
