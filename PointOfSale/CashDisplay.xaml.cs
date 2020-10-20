using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Data;
using Microsoft.VisualBasic;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashDisplay.xaml
    /// </summary>
    public partial class CashDisplay : Window
    {
        /// <summary>
        /// private var to hold the curent order
        /// </summary>
        private Order MyOrder; 
        public CashDisplay(Order TheOrder)
        {
            MyOrder = TheOrder;
           InitializeComponent();
           TotalCostText.DataContext = TheOrder;
            Binding binding_1 = new Binding("Total");
            binding_1.Mode = BindingMode.OneWay;
            binding_1.StringFormat = "c";
            TotalCostText.SetBinding(TextBox.TextProperty, binding_1);
            CashMover MyReg = new CashMover(TheOrder.Total);


            this.DataContext = MyReg;
        }
        /// <summary>
        /// prints the order recept
        /// </summary>
        public void PrintRecept()
        {
            RecieptPrinter.PrintLine(MyOrder.Number.ToString());
            RecieptPrinter.PrintLine(DateAndTime.Now.ToString());
            foreach(IOrderItem i in MyOrder.OrderItems)
            {
                RecieptPrinter.PrintLine(i.ToString());
            }
            RecieptPrinter.PrintLine(MyOrder.Subtotal.ToString());
            RecieptPrinter.PrintLine(MyOrder.Tax.ToString());
            RecieptPrinter.PrintLine("Cash");
            if(this.DataContext is CashMover reg)
            {
                RecieptPrinter.PrintLine(reg.Change.ToString());
            }
            
        }

        /// <summary>
        /// goes back to the payment options window 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        /// <summary>
        /// adds 100 to the order payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plue100_Click(object sender, RoutedEventArgs e)
        {
            if(this.DataContext is CashMover reg)
            {
                reg.HundredDollar++;
                reg.Paid += 100;
            }
        }

        /// <summary>
        /// removes 100 from the order payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void min100_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.HundredDollar > 0)
                {
                    reg.HundredDollar--;
                    reg.Paid -= 100;
                }
            }
        }

        /// <summary>
        /// the following are all payment variables that the customer gives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plus50_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.FiftyDollar++;
                reg.Paid += 50;
            }
        }

        private void plus20_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.TwentyDollar++;
                reg.Paid += 20;
            }
        }

        private void plus10_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.TenDollar++;
                reg.Paid += 10;
            }
        }

        private void plus5_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.FiveDollar++;
                reg.Paid += 5;
            }
        }

        private void plus2_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.TwoDollar++;
                reg.Paid += 2;
            }
        }

        private void plus1_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.OneDollar++;
                reg.Paid += 1;
            }
        }

        private void plus50c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.HalfDollar++;
                reg.Paid += .5;
            }
        }

        private void plus25c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.Quarter++;
                reg.Paid += .25;
            }
        }

        private void plus10c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.Dime++;
                reg.Paid += .1;
            }
        }

        private void plus5c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.Nickle++;
                reg.Paid += .05;
            }
        }

        private void plus1c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                reg.Penny++;
                reg.Paid += .01;
            }
        }

        /// <summary>
        /// the following are all mathods to remove money from the customer payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void min50_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.FiftyDollar > 0)
                {
                    reg.FiftyDollar--;
                    reg.Paid -= 50;
                }
            }
        }

        private void min20_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.TwentyDollar > 0)
                {
                    reg.TwentyDollar--;
                    reg.Paid -= 20;
                }
            }
        }

        private void min10_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.TenDollar > 0)
                {
                    reg.TenDollar--;
                    reg.Paid -= 10;
                }
            }
        }

        private void min5_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.FiveDollar > 0)
                {
                    reg.FiveDollar--;
                    reg.Paid -= 5;
                }
            }
        }

        private void min2_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.TwoDollar > 0)
                {
                    reg.TwoDollar--;
                    reg.Paid -= 2;
                }
            }
        }

        private void min1_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.OneDollar > 0)
                {
                    reg.OneDollar--;
                    reg.Paid -= 1;
                }
            }
        }

        private void min50c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.HalfDollar > 0)
                {
                    reg.HalfDollar--;
                    reg.Paid -= .5;
                }
            }
        }

        private void min25c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.Quarter > 0)
                {
                    reg.Quarter--;
                    reg.Paid -= .25;
                }
            }
        }

        private void min10c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.Dime > 0)
                {
                    reg.Dime--;
                    reg.Paid -= .1;
                }
            }
        }

        private void min5c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.Nickle > 0)
                {
                    reg.Nickle--;
                    reg.Paid -= .05;
                }
            }
        }

        private void min1c_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is CashMover reg)
            {
                if (reg.Penny > 0)
                {
                    reg.Penny--;
                    reg.Paid -= .01;
                }
            }
        }

        /// <summary>
        /// finalizes the sale and produces the change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalSaleButton_Click(object sender, RoutedEventArgs e)
        {
            ReturnButton.IsEnabled = false;
            HomeButton.Visibility = Visibility.Visible;
            FinishedDisplay.Visibility = Visibility.Visible;
            if (this.DataContext is CashMover reg)
            {
                PrintRecept();
                reg.OpenDrawer();
            }
        }
        /// <summary>
        /// returns to the main order screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
