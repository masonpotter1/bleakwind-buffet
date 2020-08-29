/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Entree option available on the menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class Double_Draugr
    {
        /// <summary>
        /// gets the price of the Item
        /// </summary>
        public double Price
        {
            get { return 7.32; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get { return 843; }
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        private bool Bun = true;
        public bool bun
        {
            get { return Bun; }
            set
            {
                if (!value) specialInstructions.Add("Hold bun");
                else { specialInstructions.Remove("Hold bun"); }
                Bun = value;
            }
        }
        private bool Ketchup = true;
        public bool ketchup
        {
            get { return Ketchup; }
            set
            {
                if (!value) specialInstructions.Add("Hold ketchup");
                else { specialInstructions.Remove("Hold ketchup"); }
                Ketchup = value;
            }
        }

        private bool Mustard = true;
        public bool mustard
        {
            get { return Mustard; }
            set
            {
                if (!value) specialInstructions.Add("Hold mustard");
                else { specialInstructions.Remove("Hold mustard"); }
                Mustard = value;
            }
        }

        private bool Pickle = true;
        public bool pickle
        {
            get { return Pickle; }
            set
            {
                if (!value) specialInstructions.Add("Hold pickle");
                else { specialInstructions.Remove("Hold pickle"); }
                Pickle = value;
            }
        }

        private bool Cheese = true;
        public bool cheese
        {
            get { return Cheese; }
            set
            {
                if (!value) specialInstructions.Add("Hold cheese");
                else { specialInstructions.Remove("Hold cheese"); }
                Cheese = value;
            }
        }

        private bool Tomato = true;
        public bool tomato
        {
            get { return Tomato; }
            set
            {
                if (!value) specialInstructions.Add("Hold tomato");
                else { specialInstructions.Remove("Hold tomato"); }
                Tomato = value;
            }
        }

        private bool Lettuce = true;
        public bool lettuce
        {
            get { return Lettuce; }
            set
            {
                if (!value) specialInstructions.Add("Hold lettuce");
                else { specialInstructions.Remove("Hold lettuce"); }
                Lettuce = value;
            }
        }

        private bool Mayo = true;
        public bool mayo
        {
            get { return Mayo; }
            set
            {
                if (!value) specialInstructions.Add("Hold mayo");
                else { specialInstructions.Remove("Hold mayo"); }
                Mayo = value;
            }
        }

        public override string ToString()
        {
            return ("Double Draugr");
        }
    }
}
