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
        /// A class representing an order of the Garden Orc Omlette
        /// </summary>
    public class GardenOrcOmelette : Entree
    {

        /// <summary>
        /// Description of the item
        /// </summary>
        /// <returns></returns>
        
        private string description = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";

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
            get { return 4.57; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public override uint Calories
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
        public override List<string> SpecialInstructions
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
                OnPropertyChanged("Hold broccoli");
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
                OnPropertyChanged("Hold mushrooms");
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
                OnPropertyChanged("Hold cheddar");
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Garden Orc Omelette \n");
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

