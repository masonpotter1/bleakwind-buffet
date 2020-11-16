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
        /// A class representing an order of the Philly Poacher
        /// </summary>
    public class PhillyPoacher : Entree
    {

        /// <summary>
        /// Description of the item
        /// </summary>
        /// <returns></returns>
       private string description = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";

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
            get { return 7.23; }
        }

        /// <summary>
        /// gets the calories 
        /// </summary>
        public override uint Calories
        {
            get { return 784; }
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
        /// A private variable representing the sirloin - defaulted to true
        /// </summary>
        private bool Sirloin = true;
        /// <summary>
        /// A public class that represents the sirloin, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool sirloin
        {
            get { return Sirloin; }
            set
            {
                if (!value) specialInstructions.Add("Hold sirloin");
                else { specialInstructions.Remove("Hold sirloin"); }
                Sirloin = value;
                OnPropertyChanged("Hold sirloin");
            }
        }
        /// <summary>
        /// A private variable representing the Onion - defaulted to true
        /// </summary>
        private bool Onion = true;
        /// <summary>
        /// A public class that represents the Onion, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool onion
        {
            get { return Onion; }
            set
            {
                if (!value) specialInstructions.Add("Hold onion");
                else { specialInstructions.Remove("Hold onion"); }
                Onion = value;
                OnPropertyChanged("Hold onion");
            }
        }

         /// <summary>
        /// A private variable representing the Roll - defaulted to true
        /// </summary>
        private bool Roll = true;
        /// <summary>
        /// A public class that represents the Roll, if false 
        /// it updates specialInstructions
        /// </summary>
        public bool roll
        {
            get { return Roll; }
            set
            {
                if (!value) specialInstructions.Add("Hold roll");
                else { specialInstructions.Remove("Hold roll"); }
                Roll = value;
                OnPropertyChanged("Hold roll");
            }
        }
        /// <summary>
        /// Override Method to return the item size and item name 
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Philly Poacher \n");
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

