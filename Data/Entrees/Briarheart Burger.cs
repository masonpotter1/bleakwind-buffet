using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Data.Entrees
{
    public class Briarheart_Burger
    {
        /// <summary>
        /// gets the price of the Item
        /// </summary>
        public double Price
        {
            get { return 6.32; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get { return 743; }
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
            set {
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
            { if (!value) specialInstructions.Add("Hold mustard");
                else { specialInstructions.Remove("Hold mustard"); }
                Mustard = value;
            }
        }

        private bool Pickle = true;
        public bool pickle
        {
            get { return Pickle; }
            set 
            { if (!value) specialInstructions.Add("Hold pickle");
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

        public override string ToString()
        {
            return ("Briarheart Burger");
        }

    }

}
