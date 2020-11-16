using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// total callories for the combo
        /// </summary>
        public uint Calories
        {
            get { return (drink.Calories + side.Calories + entree.Calories); }
        }
        /// <summary>
        /// total price of the combo
        /// </summary>
        public double Price
        {
            get { return (drink.Price + side.Price + entree.Price)-1; }
        }

        /// <summary>
        /// a string of all special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> Special = new List<string>();
                Special.Add(entree.ToString());
                Special.AddRange(entree.SpecialInstructions);
                Special.Add(side.ToString());
                Special.AddRange(side.SpecialInstructions);
                Special.Add(drink.ToString());
                Special.AddRange(drink.SpecialInstructions);
                return Special;
            }
           
        }

        /// <summary>
        /// represents The Drink in the combo, private and public
        /// </summary>
        private Drinks drink;
        public Drinks Drink
        {
            get
            {
                return drink;
            }

            set
            {
                drink = value;
                OnPropertyChanged("Size");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
                OnPropertyChanged("SpecialInstructions");
            }

        }
/// <summary>
/// represents the entree in the combo, private and public
/// </summary>
        private Entree entree;
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// represents the side in the combo, private and public
        /// </summary>
        private Side side;
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                OnPropertyChanged("Size");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Price");
                OnPropertyChanged("SpecialInstructions");
            }

        }


        public String Description { get; }

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
