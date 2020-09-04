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
    public class PhillyPoacher
    {
        /// <summary>
        /// gets the price of the Item
        /// </summary>
        public double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get { return 784; }
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        private bool Sirloin = true;
        public bool sirloin
        {
            get { return Sirloin; }
            set
            {
                if (!value) specialInstructions.Add("Hold sirloin");
                else { specialInstructions.Remove("Hold sirloin"); }
                Sirloin = value;
            }
        }
        private bool Onion = true;
        public bool onion
        {
            get { return Onion; }
            set
            {
                if (!value) specialInstructions.Add("Hold onion");
                else { specialInstructions.Remove("Hold onion"); }
                Onion = value;
            }
        }

        private bool Roll = true;
        public bool roll
        {
            get { return Roll; }
            set
            {
                if (!value) specialInstructions.Add("Hold roll");
                else { specialInstructions.Remove("Hold roll"); }
                Roll = value;
            }
        }

        public override string ToString()
        {
            return ("Philly Poache");
        }

    }
}

