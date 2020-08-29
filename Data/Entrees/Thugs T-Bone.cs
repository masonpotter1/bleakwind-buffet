using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class Thugs_T_Bone
    {        /// <summary>
             /// gets the price of the Item
             /// </summary>
        public double Price
        {
            get { return 6.44; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get { return 982; }
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        public override string ToString()
        {
            return ("Thugs T-Bone");
        }
    }
}
