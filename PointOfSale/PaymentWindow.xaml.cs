using Data;
using Microsoft.VisualBasic;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        
        public PaymentWindow()
        {
            InitializeComponent();

        }

        /// <summary>
        /// updats the data contex window
        /// </summary>
        /// <param name="TheOrder"></param>
        public void UpdateDataContex(Order TheOrder)
        {
           this.DataContext = TheOrder;
            if (this.DataContext is Order order) {
                
                Subtotal.Text = $"${order.Subtotal}";
                Tax.Text = $"${order.Tax}";
                Total.Text = $"${order.Total}";

                foreach(IOrderItem i in order.OrderItems)
                {
                    ListBoxItem box = new ListBoxItem();
                    box.Content = i;
                    PaymentList.Items.Add(box);
                }
            }
        }
        /// <summary>
        /// goes back to the main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();   
        }

        /// <summary>
        /// reads a card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardButton_Click(object sender, RoutedEventArgs e)
        {
            CardTransactionResult result;
            if (this.DataContext is Order order)
            {
                result = CardReader.RunCard(order.Total);

                if (result == CardTransactionResult.Approved)
                 {
                    PrintRecept();
                 }
            }
            
        }
        /// <summary>
        /// prints the order recept
        /// </summary>
        public void PrintRecept()
        {
            if (this.DataContext is Order MyOrder)
            {
                RecieptPrinter.PrintLine(MyOrder.Number.ToString());
                RecieptPrinter.PrintLine(DateAndTime.Now.ToString());
                foreach (IOrderItem i in MyOrder.OrderItems)
                {
                    RecieptPrinter.PrintLine(i.ToString());
                }
                RecieptPrinter.PrintLine(MyOrder.Subtotal.ToString());
                RecieptPrinter.PrintLine(MyOrder.Tax.ToString());
                RecieptPrinter.PrintLine("Card");
            }
        }

        /// <summary>
        /// opens the cash payment window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is Order order)
            {
                CashDisplay cash = new CashDisplay(order);
               Nullable<bool> done = cash.ShowDialog();
                if(done == true)
                {
                    this.DialogResult = true;
                    this.Close();
                }
            }
        }
    }
}
