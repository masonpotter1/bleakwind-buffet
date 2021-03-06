﻿/*
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
        /// A class representing an order of the Thug's T-Bone 
        /// </summary>
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// Description of the item
        /// </summary>
        /// <returns></returns>
        private string description = "Juicy T-Bone, not much else to say.";

        public override String Description
        {
            get => description;
        }

        public override event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets the price of the Item
        /// </summary>
        public override double Price
        {
            get { return 6.44; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public override uint Calories
        {
            get { return 982; }
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
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Thugs T-Bone \n");
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
