using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Data;
using RoundRegister;

namespace PointOfSale
{
    public class CashMover : INotifyPropertyChanged
    {
        /// <summary>
        /// cost of the current transaction, Amount given by customer, change needed.
        /// </summary>
        
        public double Cost;
        public event PropertyChangedEventHandler PropertyChanged;
                /// <summary>
                /// a var that shows how much the customer has paid
                /// </summary>
        private double paid = 0;
        public double Paid
        {
            get { return paid; }
            set
            {
                paid = value;
                OnPropertyChanged("Paid");
                OnPropertyChanged("Remaining");
                OnPropertyChanged("Change");

            }
        }
        /// <summary>
        /// the change owed to the customer
        /// </summary>
        private double change = 0;
        public double Change
        {
            get
            {
                if (paid > Cost)
                {
                    change = paid - Cost;
                    return change;
                }
                else { return 0; }
            }
            set
            {
                change = value;
            }
        }
        /// <summary>
        /// remaing cost of the order 
        /// </summary>
        private double remaining;
        public double Remaining
        {
            get 
            { 
                remaining = Cost - paid; 
                if(remaining > 0) {return remaining;}
                else { return 0; }
                
            }
        }
        /// <summary>
        /// opens the drawer, gets the money from the customer and adds it to the drawer, and pulls the change out of the drawer
        /// </summary>
        public void OpenDrawer()
        {
            CashDrawer.OpenDrawer();
            TakeMoney();
            GetChange();
        }

        /// <summary>
        /// number of bills and coins in the drawr currently
        /// </summary>
        public int PennyCurrent = CashDrawer.Pennies;
        public int NickleCurrent = CashDrawer.Nickels;
        public int DimeCurrent = CashDrawer.Dimes;
        public int QuarterCurrent = CashDrawer.Quarters;
        public int HalfDollarCurrent = CashDrawer.HalfDollars;

        public int OneDollarCurrent = CashDrawer.Dollars;
        public int TwoDollarCurrent = CashDrawer.Twos;
        public int FiveDollarCurrent = CashDrawer.Fives;
        public int TenDollarCurrent = CashDrawer.Tens;
        public int TwentyDollarCurrent = CashDrawer.Twenties;
        public int FiftyDollarCurrent = CashDrawer.Fifties;
        public int HundredDollarCurrent = CashDrawer.Hundreds;

        /// <summary>
        /// takes the money from the customer and then adds it to the drawr
        /// </summary>
        public void TakeMoney()
        {
            CashDrawer.Hundreds += HundredDollar;
            CashDrawer.Fifties += FiftyDollar;
            CashDrawer.Twenties += TwentyDollar;
            CashDrawer.Tens += TenDollar;
            CashDrawer.Fives += FiveDollar;
            CashDrawer.Twos += TwoDollar;
            CashDrawer.Ones += OneDollar;

            CashDrawer.HalfDollars += HalfDollar;
            CashDrawer.Quarters += Quarter;
            CashDrawer.Dimes += Dime;
            CashDrawer.Nickels += Nickle;
            CashDrawer.Pennies += Penny;
        }


        /// <summary>
        /// number of bills and coins being used to pay by customer
        /// </summary>
        private int penny = 0;
        public int Penny
        {
            get { return penny; }
            set { penny = value; OnPropertyChanged("Penny");  }
        }

        private int nickle = 0;
        public int Nickle
        {
            get { return nickle; }
            set { nickle = value; OnPropertyChanged("Nickle"); }
        }

        private int dime = 0;
        public int Dime
        {
            get { return dime; }
            set { dime = value; OnPropertyChanged("Dime"); }
        }

        private int quarter = 0;
        public int Quarter
        {
            get { return quarter; }
            set { quarter = value; OnPropertyChanged("Quarter"); }
        }

        private int halfDollar = 0;
        public int HalfDollar
        {
            get { return halfDollar; }
            set { halfDollar = value; OnPropertyChanged("HalfDollar"); }
        }


        private int oneDollar = 0;
        public int OneDollar
        {
            get { return oneDollar; }
            set { oneDollar = value; OnPropertyChanged("OneDollar"); }
        }

        private int twoDollar = 0;
        public int TwoDollar
        {
            get { return twoDollar; }
            set { twoDollar = value; OnPropertyChanged("TwoDollar"); }
        }

        private int fiveDollar = 0;
        public int FiveDollar
        {
            get { return fiveDollar; }
            set { fiveDollar = value; OnPropertyChanged("FiveDollar"); }
        }

        private int tenDollar = 0;
        public int TenDollar
        {
            get { return tenDollar; }
            set { tenDollar = value; OnPropertyChanged("TenDollar");  }
        }

        private int twentyDollar = 0;
        public int TwentyDollar
        {
            get { return twentyDollar; }
            set { twentyDollar = value; OnPropertyChanged("TwentyDollar"); }
        }

        private int fiftyDollar = 0;
        public int FiftyDollar
        {
            get { return fiftyDollar; }
            set { fiftyDollar = value; OnPropertyChanged("FiftyDollar"); }
        }

        private int hundredDollar = 0;
        public int HundredDollar
        {
            get { return hundredDollar; }
            set { hundredDollar = value; OnPropertyChanged("HundredDollar"); }
        }

        /// <summary>
        /// public constructor
        /// </summary>
        /// <param name="Cost">Cost of the current  transaction </param>
        public CashMover(double Total)
        {
            Cost = Total;
            OnPropertyChanged("Cost");
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// gets the number of coins and bills required for change;
        /// </summary>
        public void GetChange()
        {
            while(change > 100)
            {
                if (HundredDollarCurrent > 0)
                {
                    CashDrawer.Hundreds--;
                    HundredDollarChange++;
                    change -= 100;
                }
                else { break; }
            }
            while (change > 50)
            {
                if (FiftyDollarCurrent > 0)
                {
                    CashDrawer.Fifties--;
                    FiftyDollarChange++;
                    change -= 50;
                }
                else { break; }
            }
            while (change > 20)
            {
                if (TwentyDollarCurrent > 0)
                {
                    CashDrawer.Twenties--; 
                    TwentyDollarChange++;
                    change -= 20;
                }
                else { break; }
            }
            while (change > 10)
            {
                if (TenDollarCurrent > 0)
                {
                    CashDrawer.Tens--;
                    TenDollarChange++;
                    change -= 10;
                }
                else { break; }
            }
            while (change > 5)
            {
                if (FiveDollarCurrent > 0)
                {
                    CashDrawer.Fives--;
                    FiveDollarChange++;
                    change -= 5;
                }
                else { break; }
            }
            while (change > 2)
            {
                if (TwoDollarCurrent > 0)
                {
                    CashDrawer.Twos--;
                    TwoDollarChange++;
                    change -= 2;
                }
                else { break; }
            }
            while (change > 1)
            {
                if (OneDollarCurrent > 0)
                {
                    CashDrawer.Ones--;
                    OneDollarChange++;
                    change -= 1;
                }
                else { break; }
            }
            while (change > .5)
            {
                if (HalfDollarCurrent > 0)
                {
                    CashDrawer.HalfDollars--;
                    HalfDollarChange++;
                    change -= .5;
                }
                else { break; }
            }
            while (change > .25)
            {
                if (QuarterCurrent > 0)
                {
                    CashDrawer.Quarters--;
                    QuarterChange++;
                    change -= .25;
                }
                else { break; }
            }
            while (change > .1)
            {
                if (DimeCurrent > 0)
                {
                    CashDrawer.Dimes--;
                    DimeChange++;
                    change -= .1;
                }
                else { break; }
            }
            while (change > .05)
            {
                if (NickleCurrent > 0)
                {
                    CashDrawer.Nickels--;
                    NickleChange++;
                    change -= .05;
                }
                else { break; }
            }
            while (change > .01)
            {
                if (PennyCurrent > 0)
                {
                    CashDrawer.Pennies--;
                    PennyChange++;
                    change -= .01;
                }
                else { break; }
            }
        }


        /// <summary>
        /// these are the number of each currency item you will recieve for the order
        /// </summary>
         
        private int pennyChange = 0;
        public int PennyChange
        {
            get { return pennyChange; }
            set { pennyChange = value; OnPropertyChanged("PennyChange"); }
        }

        private int nickleChange = 0;
        public int NickleChange
        {
            get { return nickleChange; }
            set { nickleChange = value; OnPropertyChanged("NickleChange"); }
        }

        private int dimeChange = 0;
        public int DimeChange
        {
            get { return dimeChange; }
            set { dimeChange = value; OnPropertyChanged("DimeChange"); }
        }

        private int quarterChange = 0;
        public int QuarterChange
        {
            get { return quarterChange; }
            set { quarterChange = value; OnPropertyChanged("QuarterChange"); }
        }

        private int halfDollarChange = 0;
        public int HalfDollarChange
        {
            get { return halfDollarChange; }
            set { halfDollarChange = value; OnPropertyChanged("HalfDollarChange"); }
        }


        private int oneDollarChange = 0;
        public int OneDollarChange
        {
            get { return oneDollarChange; }
            set { oneDollarChange = value; OnPropertyChanged("OneDollarChange"); }
        }

        private int twoDollarChange = 0;
        public int TwoDollarChange
        {
            get { return twoDollarChange; }
            set { twoDollarChange = value; OnPropertyChanged("TwoDollarChange"); }
        }

        private int fiveDollarChange = 0;
        public int FiveDollarChange
        {
            get { return fiveDollarChange; }
            set { fiveDollarChange = value; OnPropertyChanged("FiveDollarChange"); }
        }

        private int tenDollarChange = 0;
        public int TenDollarChange
        {
            get { return tenDollarChange; }
            set { tenDollarChange = value; OnPropertyChanged("TenDollarChange"); }
        }

        private int twentyDollarChange = 0;
        public int TwentyDollarChange
        {
            get { return twentyDollarChange; }
            set { twentyDollarChange = value; OnPropertyChanged("TwentyDollarChange"); }
        }

        private int fiftyDollarChange = 0;
        public int FiftyDollarChange
        {
            get { return fiftyDollarChange; }
            set { fiftyDollarChange = value; OnPropertyChanged("FiftyDollarChange"); }
        }

        private int hundredDollarChange = 0;
        public int HundredDollarChange
        {
            get { return hundredDollarChange; }
            set { hundredDollarChange = value; OnPropertyChanged("HundredDollarChange"); }
        }


    }
}
