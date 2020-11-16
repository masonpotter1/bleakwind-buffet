using BleakwindBuffet.Data.Enums;
using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// the base class representing common properties of an entree
    /// </summary>
    public abstract class Drinks : IOrderItem
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// the Size of the Drink 
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// the price of the Drink in us dollars
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the callories of the Drink 
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// the special instructions of the Drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public virtual String Description { get; }
       
    }
}
