/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Drink option available 
*/

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing an order of Warrior Water
    /// </summary>
    public class WarriorWater : Drinks
    {
        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets the prices of the various sizes
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
        public override double Price
        {
            get
            {
                if (Size.Equals(Size.Small)) { return 0; } // small
                if (Size.Equals(Size.Medium)) { return 0; } // medium
                if (Size.Equals(Size.Large)) { return 0;} // large
                else {throw new NotImplementedException($"Unknown size {Size}"); }
            }
        }

        /// <summary>
        /// gets the calories in the various sizes, if the size is unrecognizes  
        /// it returns an error.
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if the size is not known 
        /// </exception>
        public override uint Calories
        {
            get
            {
                if (Size.Equals(Size.Small)) { return 0; } // small
                if (Size.Equals(Size.Medium)) { return 0; } // medium
                if (Size.Equals(Size.Large)) { return 0; } // large
                else {throw new NotImplementedException($"Unknown size {Size}"); }
            }
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
        /* 
        private variable that holds the size of the drink
        */
       


        /*
         * Private bool that is set to false by default
         */
        private bool Ice = true;
        /// <summary>
        /// Public method to return or set the bool "Ice" 
        /// if False, Special instruction is to "Hold ice'
        /// </summary>
        public bool ice
        {
            get { return Ice; }
            set
            {
                if (!value) specialInstructions.Add("Hold ice");
                else { specialInstructions.Remove("Hold ice"); }
                Ice = value;
                OnPropertyChanged("Hold ice");
            }
        }
        /*
         * Private bool that is set to false by default - represents if 
         * Lemon is added to the water
         */
        private bool Lemon = false;
        /// <summary>
        /// Public method to return or set the bool "Lemon" 
        /// if True, Special instruction is to "Add Lemon"
        /// </summary>
        public bool lemon
        {
            get { return Lemon; }
            set
            {
                if (!value) specialInstructions.Add("Add lemon");
                else { specialInstructions.Remove("Add lemon"); }
                Lemon = value;
                OnPropertyChanged("Add lemon");
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Size} Warrior Water \n");
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
        /// the name of the item
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return ("Warrior Water");
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
