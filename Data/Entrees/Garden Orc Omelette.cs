﻿/*
* Author: Mason Potter
* Class name: CIS 400
* Purpose: One Entree option available on the menu
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
        /// <summary>
        /// A class representing an order of the Garden Orc Omlette
        /// </summary>
    public class GardenOrcOmelette
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

        /* 
         private vriable of the list of special instructions 
        */
        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// Public method to return the list of instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }


        /// <summary>
        /// A private variable representing the broccoli - defaulted to true
        /// </summary>
        private bool Broccoli = true;
        /// <summary>
        /// A public class that represents the broccoli, if false 
        /// it updates specialInstructions
        /// </summary>
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
        /// <summary>
        /// A private variable representing the mushrooms - defaulted to true
        /// </summary>
        private bool Mushrooms = true;
        /// <summary>
        /// A public class that represents the mushrooms, if false 
        /// it updates specialInstructions
        /// </summary>
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
            }
        }

        /// <summary>
        /// A private variable representing the Cheddar - defaulted to true
        /// </summary>
        private bool Cheddar = true;
        /// <summary>
        /// A public class that represents the Cheddar, if false 
        /// it updates specialInstructions
        /// </summary>
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
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            return ("Garden Orc Omelette");
        }
    }
}
