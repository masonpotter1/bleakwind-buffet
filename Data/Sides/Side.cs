﻿using BleakwindBuffet.Data.Enums;
using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// the Size of the Side 
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// the price of the Side in us dollars
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the callories of the Side 
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// the special instructions of the Side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public virtual String Description { get; }
    }
}
