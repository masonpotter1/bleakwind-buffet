using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class Garden_Orc_Omelette
    {
        /// <summary>
        /// gets the price of the Item
        /// </summary>
        public double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get { return 404; }
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        private bool Broccoli = true;
        public bool broccoli
        {
            get { return Broccoli; }
            set
            {
                if (!value) specialInstructions.Add("Hold broccoli");
                else { specialInstructions.Remove("Hold broccoli"); }
                Broccoli = value;
            }
        }
        private bool Mushrooms = true;
        public bool mushrooms
        {
            get { return Mushrooms; }
            set
            {
                if (!value) specialInstructions.Add("Hold mushrooms");
                else { specialInstructions.Remove("Hold mushrooms"); }
                Mushrooms = value;
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

        private bool Cheddar = true;
        public bool cheddar
        {
            get { return Cheddar; }
            set
            {
                if (!value) specialInstructions.Add("Hold cheddar");
                else { specialInstructions.Remove("Hold cheddar"); }
                Cheddar = value;
            }
        }

        public override string ToString()
        {
            return ("Garden Orc Omelette");
        }
    }
}

