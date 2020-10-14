using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Collections;
namespace Data
{
    public class Order : ICollection<IOrderItem>,INotifyPropertyChanged,INotifyCollectionChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public List<IOrderItem> OrderItems = new List<IOrderItem>();

        public void Add(IOrderItem thing)
        {
            OrderItems.Add(thing);
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Calories");
            OnPropertyChanged("Total");
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add,thing));
        }

        public bool Remove(IOrderItem thing)
        {
            bool checker = OrderItems.Remove(thing);
            OrderItems.Add(thing);
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Calories");
            OnPropertyChanged("Total");
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, thing));
            thing.PropertyChanged -= ItemEventChanged;
            return checker;
        }

        public void Clear()
        {
            ((ICollection<IOrderItem>)OrderItems).Clear();
            OnPropertyChanged("Subtotal");
            OnPropertyChanged("Tax");
            OnPropertyChanged("Calories");
            OnPropertyChanged("Total");
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        /// <summary>
        /// checks to see if the item is in the order
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public bool Contains(IOrderItem Item)
        {
            return ((ICollection<IOrderItem>)OrderItems).Contains(Item);

        }
        /// <summary>
        /// coppies the order
        /// </summary>
        /// <param name="newArray"></param>
        /// <param name="Index"></param>
        public void CopyTo(IOrderItem[] newArray, int Index)
        {
            ((ICollection<IOrderItem>)OrderItems).CopyTo(newArray, Index);
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return ((IEnumerable<IOrderItem>)OrderItems).GetEnumerator();

        }

       IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)OrderItems).GetEnumerator();
        }

        public double SalesTaxRate { get; set; } = .12;

        private double subTotal = 0 ;
        public double Subtotal
        {
            get
            {
                subTotal = 0;
                foreach(IOrderItem item in OrderItems)
                {
                    subTotal += item.Price;
                }
                return subTotal;
            }
        }

        private double total = 0;
        public double Total
        {
            get { total= Subtotal + Tax; return total; }
        }

        private double tax = 0;
        public double Tax
        {
            get
            {
                tax = subTotal * SalesTaxRate;
                return tax;
            }
        }
        private static int nextNum = 1;
        public int Number { 
            get { int temp = nextNum; nextNum++; return temp; } 
            
        } 


        public uint Calories
        {
            get
            {
                uint cal = 0;
                foreach(IOrderItem item in OrderItems)
                {
                    cal += item.Calories;
                }
                return cal;
            }
        }

        public int Count => ((ICollection<IOrderItem>)OrderItems).Count;
        public bool IsReadOnly => ((ICollection<IOrderItem>)OrderItems).IsReadOnly;

        private void ItemEventChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged("Subtotal");
                OnPropertyChanged("Tax");
                OnPropertyChanged("Total");
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChanged("Calories");
            }
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
