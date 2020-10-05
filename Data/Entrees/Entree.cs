using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// the base class representing common properties of an entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// the price of the entree in us dollars
        /// </summary>
        public virtual double Price { get; }
        /// <summary>
        /// the callories of the entree 
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// the special instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
