using BleakwindBuffet.Data.Drinks;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IOrderItem Order;
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// shows flavor options for salior soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Soda_Click(object sender, RoutedEventArgs e)
        {
            Order = new SailorSoda(); 
            SodaF1.Visibility = Visibility.Visible;
            SodaF2.Visibility = Visibility.Visible;
            SodaF3.Visibility = Visibility.Visible;
            SodaF4.Visibility = Visibility.Visible;
            SodaF5.Visibility = Visibility.Visible;
            SodaF6.Visibility = Visibility.Visible;
            DrinkIce.Visibility = Visibility.Visible;
            DrinkIce.IsChecked = true;
        }

        /// <summary>
        /// these are the boxes that appear when sailor soda flavor and ice options appear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodaF2_Checked(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            SodaF1.IsChecked = false; SodaF3.IsChecked = false; SodaF4.IsChecked = false; SodaF5.IsChecked = false; SodaF6.IsChecked = false;
        }

        private void SodaF3_Checked(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            SodaF2.IsChecked = false; SodaF1.IsChecked = false; SodaF4.IsChecked = false; SodaF5.IsChecked = false; SodaF6.IsChecked = false;
        }

        private void SodaF4_Checked(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            SodaF2.IsChecked = false; SodaF3.IsChecked = false; SodaF1.IsChecked = false; SodaF5.IsChecked = false; SodaF6.IsChecked = false;
        }

        private void SodaF5_Checked(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            SodaF2.IsChecked = false; SodaF3.IsChecked = false; SodaF4.IsChecked = false; SodaF1.IsChecked = false; SodaF6.IsChecked = false;
        }

        private void SodaF6_Checked(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            SodaF2.IsChecked = false; SodaF3.IsChecked = false; SodaF4.IsChecked = false; SodaF5.IsChecked = false; SodaF1.IsChecked = false;
        }

        private void SodaF1_Checked_1(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            SodaF2.IsChecked = false; SodaF3.IsChecked = false; SodaF4.IsChecked = false; SodaF5.IsChecked = false; SodaF6.IsChecked = false;
        } // end of soda flavors

        /// <summary>
        /// milk button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Milk_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            DrinkIce.Visibility = Visibility.Visible;
            DrinkIce.IsChecked = false;
        }
        /// <summary>
        /// aj click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Aj_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            DrinkIce.Visibility = Visibility.Visible;
            DrinkIce.IsChecked = false;
        }

        private void Button_Coffee(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            DrinkIce.Visibility = Visibility.Visible;
            DrinkIce.IsChecked = false;
            check_RoomForCream.Visibility = Visibility.Visible;
            Check_Decaf.Visibility = Visibility.Visible;


        }
        private void Button_Water_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            DrinkIce.Visibility = Visibility.Visible;
            DrinkIce.IsChecked = true;
            Check_Lemon.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// A Function that sets all check boxes to hiden.
        /// </summary>
        private void allButtonsFalse()
        {
            DrinkIce.Visibility = Visibility.Hidden;
            Check_Lemon.Visibility = Visibility.Hidden;
            check_RoomForCream.Visibility = Visibility.Hidden;
            Check_Decaf.Visibility = Visibility.Hidden;
            SodaF1.Visibility = Visibility.Hidden;
            SodaF2.Visibility = Visibility.Hidden;
            SodaF3.Visibility = Visibility.Hidden;
            SodaF4.Visibility = Visibility.Hidden;
            SodaF5.Visibility = Visibility.Hidden;
            SodaF6.Visibility = Visibility.Hidden;

            Check_Bun.Visibility = Visibility.Hidden;
            Check_Cheese.Visibility = Visibility.Hidden;
            Check_Ketchup.Visibility = Visibility.Hidden;
            Check_Mustard.Visibility = Visibility.Hidden;
            Check_Pickle.Visibility = Visibility.Hidden;
            Check_Lettuce.Visibility = Visibility.Hidden;
            Check_Mayo.Visibility = Visibility.Hidden;
            Check_tomato.Visibility = Visibility.Hidden;
            Check_Bacon.Visibility = Visibility.Hidden;
            Check_Egg.Visibility = Visibility.Hidden;

            Check_Egg_Skelly.Visibility = Visibility.Hidden;
            Check_HashBrowns.Visibility = Visibility.Hidden;
            Check_Sausage_Link.Visibility = Visibility.Hidden;
            Check_Pancakes.Visibility = Visibility.Hidden;

            Check_Broccoli.Visibility = Visibility.Hidden;
            Check_Cheddar.Visibility = Visibility.Hidden;
            Check_Tomato_Omelette.Visibility = Visibility.Hidden;
            Check_Mushrooms.Visibility = Visibility.Hidden;

            Check_Onion.Visibility = Visibility.Hidden;
            Check_Sirloin.Visibility = Visibility.Hidden;
            Check_Roll.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// These Buttons Represent the Sides on the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();

        }

        private void Button_DragonWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
        }

        private void Button_Vokun_Salad_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
        }

        private void Button_Fried_Miraak_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
        }


        /// <summary>
        /// The Following include the buttons for the Entrees on the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Briarheart_Burger_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            Check_Bun.Visibility = Visibility.Visible;
            Check_Cheese.Visibility = Visibility.Visible;
            Check_Ketchup.Visibility = Visibility.Visible;
            Check_Mustard.Visibility = Visibility.Visible;
            Check_Pickle.Visibility = Visibility.Visible;
        }

        private void Button_Double_Draughr_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            Check_Bun.Visibility = Visibility.Visible;
            Check_Cheese.Visibility = Visibility.Visible;
            Check_Ketchup.Visibility = Visibility.Visible;
            Check_Mustard.Visibility = Visibility.Visible;
            Check_Pickle.Visibility = Visibility.Visible;
            Check_Lettuce.Visibility = Visibility.Visible;
            Check_Mayo.Visibility = Visibility.Visible;
            Check_tomato.Visibility = Visibility.Visible;
        }

        private void Button_Thalmor_Triple_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            Check_Bun.Visibility = Visibility.Visible;
            Check_Cheese.Visibility = Visibility.Visible;
            Check_Ketchup.Visibility = Visibility.Visible;
            Check_Mustard.Visibility = Visibility.Visible;
            Check_Pickle.Visibility = Visibility.Visible;
            Check_Lettuce.Visibility = Visibility.Visible;
            Check_Mayo.Visibility = Visibility.Visible;
            Check_tomato.Visibility = Visibility.Visible;
            Check_Bacon.Visibility = Visibility.Visible;
            Check_Egg.Visibility = Visibility.Visible;
        }

        private void Button_SmokeHouse_Skeleton_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            Check_Egg_Skelly.Visibility = Visibility.Visible;
            Check_HashBrowns.Visibility = Visibility.Visible;
            Check_Sausage_Link.Visibility = Visibility.Visible;
            Check_Pancakes.Visibility = Visibility.Visible;
        }

        private void Button_Garden_Orc_Omelette_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            Check_Broccoli.Visibility = Visibility.Visible;
            Check_Cheddar.Visibility = Visibility.Visible;
            Check_Tomato_Omelette.Visibility = Visibility.Visible;
            Check_Mushrooms.Visibility = Visibility.Visible;
        }

        private void Button_Philly_Poacher_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();
            Check_Onion.Visibility = Visibility.Visible;
            Check_Sirloin.Visibility = Visibility.Visible;
            Check_Roll.Visibility = Visibility.Visible;
        }

        private void Button_Thugs_T_Bone_Click(object sender, RoutedEventArgs e)
        {
            allButtonsFalse();

        }
    }
}
