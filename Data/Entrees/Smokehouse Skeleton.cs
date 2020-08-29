using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class Smokehouse_Skeleton
    {
        /// <summary>
        /// gets the price of the Item
        /// </summary>
        public double Price
        {
            get { return 5.62; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public uint Calories
        {
            get { return 602; }
        }

        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        private bool SausageLink = true;
        public bool sausageLink
        {
            get { return SausageLink; }
            set
            {
                if (!value) specialInstructions.Add("Hold sausage");
                else { specialInstructions.Remove("Hold sausage"); }
                SausageLink = value;
            }
        }
        private bool HashBrowns = true;
        public bool hashBrowns
        {
            get { return HashBrowns; }
            set
            {
                if (!value) specialInstructions.Add("Hold hashBrowns");
                else { specialInstructions.Remove("Hold hashBrowns"); }
                HashBrowns = value;
            }
        }

        private bool Pancake = true;
        public bool pancake
        {
            get { return Pancake; }
            set
            {
                if (!value) specialInstructions.Add("Hold pancake");
                else { specialInstructions.Remove("Hold pancake"); }
                Pancake = value;
            }
        }

        private bool Egg = true;
        public bool egg
        {
            get { return Egg; }
            set
            {
                if (!value) specialInstructions.Add("Hold eggs");
                else { specialInstructions.Remove("Hold eggs"); }
                Egg = value;
            }
        }

        public override string ToString()
        {
            return ("Smokehouse Skeleton");
        }
    }
}

