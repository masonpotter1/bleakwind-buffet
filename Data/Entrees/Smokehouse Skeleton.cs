/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Entree option available on the menu
*/

using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
        /// <summary>
        /// A class representing an order of the Smokehouse Skeleton
        /// </summary>
    public class SmokehouseSkeleton : Entree
    {
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets the price of the Item
        /// </summary>
        public override double Price
        {
            get { return 5.62; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public override uint Calories
        {
            get { return 602; }
        }

         /* 
         private vriable of the list of special instructions 
        */
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Public method to return the list of instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        /// <summary>
        /// A private variable representing the sausageLink - defaulted to true
        /// </summary>
        private bool SausageLink = true;
        /// <summary>
        /// A public class that represents the sausageLink, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool sausageLink
        {
            get { return SausageLink; }
            set
            {
                if (!value) specialInstructions.Add("Hold sausage");
                else { specialInstructions.Remove("Hold sausage"); }
                SausageLink = value;
                OnPropertyChanged("Hold sausage");
            }
        }
        /// <summary>
        /// A private variable representing the HashBrowns - defaulted to true
        /// </summary>
        private bool HashBrowns = true;
        /// <summary>
        /// A public class that represents the HashBrowns, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool hashBrowns
        {
            get { return HashBrowns; }
            set
            {
                if (!value) specialInstructions.Add("Hold HashBrowns");
                else { specialInstructions.Remove("Hold HashBrowns"); }
                HashBrowns = value;
                OnPropertyChanged("Hold HashBrowns");
            }
        }

        /// <summary>
        /// A private variable representing the Pancake - defaulted to true
        /// </summary>
        private bool Pancake = true;
        /// <summary>
        /// A public class that represents the Pancake, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool pancake
        {
            get { return Pancake; }
            set
            {
                if (!value) specialInstructions.Add("Hold pancake");
                else { specialInstructions.Remove("Hold pancake"); }
                Pancake = value;
                OnPropertyChanged("Hold pancake");
            }
        }

        /// <summary>
        /// A private variable representing the Egg - defaulted to true
        /// </summary>
        private bool Egg = true;
        /// <summary>
        /// A public class that represents the Egg, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool egg
        {
            get { return Egg; }
            set
            {
                if (!value) specialInstructions.Add("Hold eggs");
                else { specialInstructions.Remove("Hold eggs"); }
                Egg = value;
                OnPropertyChanged("Hold eggs");
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Smokehouse Skeleton \n");
            for (int i = 0; i < specialInstructions.Count; i++)
            {
                sb.Append(" -");
                sb.Append(specialInstructions[i]);
                sb.Append("\n");
            }
            sb.Append($"                                                                         ${Price}");

            string final = sb.ToString();
            return (final);
        }
        /// <summary>
        /// The Property that was changes - creates a new changed event.
        /// </summary>
        /// <param name="name"></param>
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
    }
}

