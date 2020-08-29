using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    class Vokun_Salad
    {
        public double Price
        {
            get
            {
                if (OrderSize.CompareTo(0) == 0) { return .93; } // small
                if (OrderSize.CompareTo(1) == 0) { return 1.28; } // medium
                else { return 1.82; } // large
            }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (OrderSize.CompareTo(0) == 0) { return 41; } // small
                if (OrderSize.CompareTo(1) == 0) { return 52; } // medium
                else { return 73; } // large
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
            return ($"{OrderSize} Vokun Salad");
        }
    }
}
