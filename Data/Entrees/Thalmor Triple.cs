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
        /// A class representing an order of the Thalmor Triple
        /// </summary>
    public class ThalmorTriple : Entree
    {
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets the price of the Item
        /// </summary>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public override uint Calories
        {
            get { return 943; }
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
        /// A private variable representing a bun - defaulted to true
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// A public class that represents a bun, if false it updates specialInstructions
        /// </summary>
        public bool bun
        {
            get { return Bun; }
            set
            {
                if (!value) specialInstructions.Add("Hold bun");
                else { specialInstructions.Remove("Hold bun"); }
                Bun = value;
                OnPropertyChanged("Hold bun");
            }
        }
        /// <summary>
        /// A private variable representing the ketchup - defaulted to true
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// A public class that represents the ketchup, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool ketchup
        {
            get { return Ketchup; }
            set
            {
                if (!value) specialInstructions.Add("Hold ketchup");
                else { specialInstructions.Remove("Hold ketchup"); }
                Ketchup = value;
                OnPropertyChanged("Hold ketchup");
            }
        }

        /// <summary>
        /// A private variable representing the Mustard - defaulted to true
        /// </summary>
        private bool Mustard = true;
        /// <summary>
        /// A public class that represents the Mustard, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool mustard
        {
            get { return Mustard; }
            set
            {
                if (!value) specialInstructions.Add("Hold mustard");
                else { specialInstructions.Remove("Hold mustard"); }
                Mustard = value;
                OnPropertyChanged("Hold mustard");
            }
        }

        /// <summary>
        /// A private variable representing the Pickle - defaulted to true
        /// </summary>
        private bool Pickle = true;
        /// <summary>
        /// A public class that represents the Pickle, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool pickle
        {
            get { return Pickle; }
            set
            {
                if (!value) specialInstructions.Add("Hold pickle");
                else { specialInstructions.Remove("Hold pickle"); }
                Pickle = value;
                OnPropertyChanged("Hold pickle");
            }
        }

        /// <summary>
        /// A private variable representing the Cheese - defaulted to true
        /// </summary>
        private bool Cheese = true;
        /// <summary>
        /// A public class that represents the Cheese, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool cheese
        {
            get { return Cheese; }
            set
            {
                if (!value) specialInstructions.Add("Hold cheese");
                else { specialInstructions.Remove("Hold cheese"); }
                Cheese = value;
                OnPropertyChanged("Hold cheese");
            }
        }

        /// <summary>
        /// A private variable representing the Tomato - defaulted to true
        /// </summary>
        private bool Tomato = true;
        /// <summary>
        /// A public class that represents the Tomato, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool tomato
        {
            get { return Tomato; }
            set
            {
                if (!value) specialInstructions.Add("Hold tomato");
                else { specialInstructions.Remove("Hold tomato"); }
                Tomato = value;
                OnPropertyChanged("Hold tomato");
            }
        }

        /// <summary>
        /// A private variable representing the Lettus - defaulted to true
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// A public class that represents the Lettus, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool lettuce
        {
            get { return Lettuce; }
            set
            {
                if (!value) specialInstructions.Add("Hold lettuce");
                else { specialInstructions.Remove("Hold lettuce"); }
                Lettuce = value;
                OnPropertyChanged("Hold lettuce");
            }
        }

        /// <summary>
        /// A private variable representing the Mayo - defaulted to true
        /// </summary>
        private bool Mayo = true;
        /// <summary>
        /// A public class that represents the Mayo, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool mayo
        {
            get { return Mayo; }
            set
            {
                if (!value) specialInstructions.Add("Hold mayo");
                else { specialInstructions.Remove("Hold mayo"); }
                Mayo = value;
                OnPropertyChanged("Hold mayo");
            }
        }

        /// <summary>
        /// A private variable representing the Bacon - defaulted to true
        /// </summary>
        private bool Bacon = true;
        /// <summary>
        /// A public class that represents the Bacon, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool bacon
        {
            get { return Bacon; }
            set
            {
                if (!value) specialInstructions.Add("Hold bacon");
                else { specialInstructions.Remove("Hold bacon"); }
                Bacon = value;
                OnPropertyChanged("Hold bacon");
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
                if (!value) specialInstructions.Add("Hold egg");
                else { specialInstructions.Remove("Hold egg"); }
                Egg = value;
                OnPropertyChanged("Hold Egg");
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Thalmor Triple \n");
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
