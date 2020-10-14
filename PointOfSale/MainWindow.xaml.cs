using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
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

        
        public MainWindow()
        {
            InitializeComponent();
            Order ThisOrder = new Order();
            Orderlist.DataContext =ThisOrder;

            ui_Total.DataContext = Orderlist.DataContext;
            ui_Tax.DataContext = Orderlist.DataContext;
            ui_Subtotal.DataContext = Orderlist.DataContext;

            Binding binding_1 = new Binding("Subtotal");
            binding_1.Mode = BindingMode.OneWay;

            Binding binding_2 = new Binding("Tax");
            binding_2.Mode = BindingMode.OneWay;

            Binding binding_3 = new Binding("Total");
            binding_3.Mode = BindingMode.OneWay;

            

            
            ui_Number.Text = ($"Order Number #{ThisOrder.Number.ToString()}");
            ui_Subtotal.SetBinding(TextBox.TextProperty, binding_1) ;
            ui_Tax.SetBinding(TextBox.TextProperty, binding_2);
            ui_Total.SetBinding(TextBox.TextProperty, binding_3);
            
            
           

        }

        /// <summary>
        /// shows flavor options for salior soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Soda_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new SailorSoda();

            SodaF1.Visibility = Visibility.Visible;
            SodaF2.Visibility = Visibility.Visible;
            SodaF2.IsChecked = true;
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
        private void SodaF2_Checked(object sender, RoutedEventArgs e)//cherry
        {
            if (this.DataContext is SailorSoda drink)
            {
                drink.flavor = SodaFlavor.Cherry;
            }
            SodaF1.IsChecked = false; SodaF3.IsChecked = false; SodaF4.IsChecked = false; SodaF5.IsChecked = false; SodaF6.IsChecked = false;
        }

        private void SodaF3_Checked(object sender, RoutedEventArgs e)//GrapeFruit
        {
            if (this.DataContext is SailorSoda drink)
            {
                drink.flavor = SodaFlavor.Grapefruit;
            }
            SodaF2.IsChecked = false; SodaF1.IsChecked = false; SodaF4.IsChecked = false; SodaF5.IsChecked = false; SodaF6.IsChecked = false;
        }

        private void SodaF4_Checked(object sender, RoutedEventArgs e)//Lemon
        {
            if (this.DataContext is SailorSoda drink)
            {
                drink.flavor = SodaFlavor.Lemon;
            }
            SodaF2.IsChecked = false; SodaF3.IsChecked = false; SodaF1.IsChecked = false; SodaF5.IsChecked = false; SodaF6.IsChecked = false;
        }

        private void SodaF5_Checked(object sender, RoutedEventArgs e)//Peach
        {
            if (this.DataContext is SailorSoda drink)
            {
                drink.flavor = SodaFlavor.Peach;
            }
            SodaF2.IsChecked = false; SodaF3.IsChecked = false; SodaF4.IsChecked = false; SodaF1.IsChecked = false; SodaF6.IsChecked = false;
        }

        private void SodaF6_Checked(object sender, RoutedEventArgs e)//Watermellon
        {
            if (this.DataContext is SailorSoda drink)
            {
                drink.flavor = SodaFlavor.Watermelon;
            }
            SodaF2.IsChecked = false; SodaF3.IsChecked = false; SodaF4.IsChecked = false; SodaF5.IsChecked = false; SodaF1.IsChecked = false;
        }

        private void SodaF1_Checked_1(object sender, RoutedEventArgs e)//Blackberry
        {
            if(this.DataContext is SailorSoda drink)
            {
                drink.flavor = SodaFlavor.Blackberry;
            }

            SodaF2.IsChecked = false; SodaF3.IsChecked = false; SodaF4.IsChecked = false; SodaF5.IsChecked = false; SodaF6.IsChecked = false;
        } // end of soda flavors

        /// <summary>
        /// milk button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Milk_Click(object sender, RoutedEventArgs e)
        {
           this.DataContext = new MarkarthMilk();
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
            this.DataContext = new AretinoAppleJuice();
           allButtonsFalse();
            DrinkIce.Visibility = Visibility.Visible;
            DrinkIce.IsChecked = false;
        }

        private void Button_Coffee(object sender, RoutedEventArgs e)
        {
            this.DataContext = new CandlehearthCoffee();
           allButtonsFalse();
            DrinkIce.Visibility = Visibility.Visible;
            DrinkIce.IsChecked = false;
            check_RoomForCream.Visibility = Visibility.Visible;
            Check_Decaf.Visibility = Visibility.Visible;


        }
        private void Button_Water_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new WarriorWater();
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
            this.DataContext = new MadOtarGrits();
            allButtonsFalse();
            
        }

        private void Button_DragonWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new DragonbornWaffleFries();
            allButtonsFalse();
        }

        private void Button_Vokun_Salad_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new VokunSalad();
           allButtonsFalse();
        }

        private void Button_Fried_Miraak_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new FriedMiraak();
           allButtonsFalse();
        }


        /// <summary>
        /// The Following include the buttons for the Entrees on the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Briarheart_Burger_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new BriarheartBurger();
           allButtonsFalse();
            Check_Bun.Visibility = Visibility.Visible;
            Check_Cheese.Visibility = Visibility.Visible;
            Check_Ketchup.Visibility = Visibility.Visible;
            Check_Mustard.Visibility = Visibility.Visible;
            Check_Pickle.Visibility = Visibility.Visible;

            Check_Bun.IsChecked = true;
            Check_Cheese.IsChecked = true;
            Check_Ketchup.IsChecked = true;
            Check_Mustard.IsChecked = true;
            Check_Pickle.IsChecked = true;
        }

        private void Button_Double_Draughr_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new DoubleDraugr();
           allButtonsFalse();
            Check_Bun.Visibility = Visibility.Visible;
            Check_Cheese.Visibility = Visibility.Visible;
            Check_Ketchup.Visibility = Visibility.Visible;
            Check_Mustard.Visibility = Visibility.Visible;
            Check_Pickle.Visibility = Visibility.Visible;
            Check_Lettuce.Visibility = Visibility.Visible;
            Check_Mayo.Visibility = Visibility.Visible;
            Check_tomato.Visibility = Visibility.Visible;

            Check_Bun.IsChecked = true;
            Check_Cheese.IsChecked = true;
            Check_Ketchup.IsChecked = true;
            Check_Mustard.IsChecked = true;
            Check_Pickle.IsChecked = true;
            Check_Lettuce.IsChecked = true;
            Check_Mayo.IsChecked = true;
            Check_tomato.IsChecked = true;

        }

        private void Button_Thalmor_Triple_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new ThalmorTriple();
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

            Check_Bun.IsChecked = true;
            Check_Cheese.IsChecked = true;
            Check_Ketchup.IsChecked = true;
            Check_Mustard.IsChecked = true;
            Check_Pickle.IsChecked = true;
            Check_Lettuce.IsChecked = true;
            Check_Mayo.IsChecked = true;
            Check_tomato.IsChecked = true;
            Check_Bacon.IsChecked = true;
            Check_Egg.IsChecked = true;
        }

        private void Button_SmokeHouse_Skeleton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new SmokehouseSkeleton();
           allButtonsFalse();
            Check_Egg_Skelly.Visibility = Visibility.Visible;
            Check_HashBrowns.Visibility = Visibility.Visible;
            Check_Sausage_Link.Visibility = Visibility.Visible;
            Check_Pancakes.Visibility = Visibility.Visible;
        }

        private void Button_Garden_Orc_Omelette_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new GardenOrcOmelette();
           allButtonsFalse();
            Check_Broccoli.Visibility = Visibility.Visible;
            Check_Cheddar.Visibility = Visibility.Visible;
            Check_Tomato_Omelette.Visibility = Visibility.Visible;
            Check_Mushrooms.Visibility = Visibility.Visible;
        }

        private void Button_Philly_Poacher_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new PhillyPoacher();
           allButtonsFalse();
            Check_Onion.Visibility = Visibility.Visible;
            Check_Sirloin.Visibility = Visibility.Visible;
            Check_Roll.Visibility = Visibility.Visible;
        }

        private void Button_Thugs_T_Bone_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new ThugsTBone();
           allButtonsFalse();
            
        }



        private void Button_Small_Click(object sender, RoutedEventArgs e)
        {
            Button_Small.Opacity = 100;
            Button_Medium.Opacity = .50;
            Button_Large.Opacity = .50;

            if (this.DataContext is Drinks drink)
            {
                drink.Size = BleakwindBuffet.Data.Enums.Size.Small;
            }

            if (this.DataContext is Side side)
            {
                side.Size = BleakwindBuffet.Data.Enums.Size.Small;
            }


        }

        private void Button_Medium_Click(object sender, RoutedEventArgs e)
        {
            Button_Medium.Opacity = 100;
            Button_Small.Opacity = .50;
            Button_Large.Opacity = .50;

            if (this.DataContext is Drinks drink)
            {
                drink.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            }

            if (this.DataContext is Side side)
            {
                side.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            }
        }

        private void Button_Large_Click(object sender, RoutedEventArgs e)
        {
            Button_Large.Opacity = 1.00;
            Button_Medium.Opacity = .50;
            Button_Small.Opacity = .50;

            if (this.DataContext is Drinks drink)
            {
                drink.Size = BleakwindBuffet.Data.Enums.Size.Large;
            }

            if (this.DataContext is Side side)
            {
                side.Size = BleakwindBuffet.Data.Enums.Size.Large;
            }


        }


        private void Checked_Bun(object sender, RoutedEventArgs e)
        {
            if (Check_Bun.IsChecked == false)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.bun = false;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.bun = false;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.bun = false;

                }
            }
            
            else if (Check_Bun.IsChecked == true)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.bun = true;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.bun = true;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.bun = true;

                }
            }
        }
        private void Checked_Cheese(object sender, RoutedEventArgs e)
        {
            if (Check_Cheese.IsChecked == false)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.cheese = false;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.cheese = false;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.cheese = false;

                }
            }

            else if (Check_Cheese.IsChecked == true)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.cheese = true;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.cheese = true;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.cheese = true;

                }
            }

        }
        private void Checked_Ketchup(object sender, RoutedEventArgs e)
        {
            if (Check_Ketchup.IsChecked == false)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.ketchup = false;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.ketchup = false;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.ketchup = false;

                }
            }

            else if (Check_Ketchup.IsChecked == true)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.ketchup = true;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.ketchup = true;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.ketchup = true;

                }
            }

        }
        private void Checked_Mustard(object sender, RoutedEventArgs e)
        {
            if (Check_Mustard.IsChecked == false)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.mustard = false;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.mustard = false;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.mustard = false;

                }
            }

            else if (Check_Mustard.IsChecked == true)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.mustard = true;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.mustard = true;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.mustard = true;

                }
            }

        }
        private void Checked_Pickle(object sender, RoutedEventArgs e)
        {
            if (Check_Pickle.IsChecked == false)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.pickle = false;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.pickle = false;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.pickle = false;

                }
            }

            else if (Check_Pickle.IsChecked == true)
            {
                if (this.DataContext is BriarheartBurger singel)
                {
                    singel.pickle = true;

                }
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.pickle = true;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.pickle = true;

                }
            }

        }
        private void Checked_Lettuce(object sender, RoutedEventArgs e)
        {
            if (Check_Lettuce.IsChecked == false)
            {
                
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.lettuce = false;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.lettuce = false;

                }
            }

            else if (Check_Lettuce.IsChecked == true)
            {
               
                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.lettuce = true;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.lettuce = true;

                }
            }

        }
        private void Checked_Mayo(object sender, RoutedEventArgs e)
        {
            if (Check_Mayo.IsChecked == false)
            {

                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.mayo = false;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.mayo = false;

                }
            }

            else if (Check_Mayo.IsChecked == true)
            {

                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.mayo = true;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.mayo = true;

                }
            }

        }
        private void Checked_tomato(object sender, RoutedEventArgs e)
        {
            if (Check_tomato.IsChecked == false)
            {

                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.tomato = false;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.tomato = false;

                }
            }

            else if (Check_tomato.IsChecked == true)
            {

                if (this.DataContext is DoubleDraugr Double)
                {
                    Double.tomato = true;

                }
                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.tomato = true;

                }
            }

        }
        private void Checked_Bacon(object sender, RoutedEventArgs e)
        {
            if (Check_Bacon.IsChecked == false)
            {

                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.bacon = false;

                }
            }

            else if (Check_Bacon.IsChecked == true)
            {

                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.bacon = true;

                }
            }

        }
        private void Checked_Egg(object sender, RoutedEventArgs e)
        {
            if (Check_Egg.IsChecked == false)
            {

                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.egg = false;

                }
            }

            else if (Check_Egg.IsChecked == true)
            {

                if (this.DataContext is ThalmorTriple tripple)
                {
                    tripple.egg = true;

                }
            }

        }


        private void Checked_Egg_Skelly(object sender, RoutedEventArgs e)
        {
            if (Check_Egg_Skelly.IsChecked == false)
            {

                if (this.DataContext is SmokehouseSkeleton ss)
                {
                    ss.egg = false;

                }
            }

            else if (Check_Egg_Skelly.IsChecked == true)
            {

                if (this.DataContext is SmokehouseSkeleton ss)
                {
                    ss.egg = true;

                }
            }

        }
        private void Checked_HashBrowns(object sender, RoutedEventArgs e)
        {
            if (Check_HashBrowns.IsChecked == false)
            {

                if (this.DataContext is SmokehouseSkeleton ss)
                {
                    ss.hashBrowns = false;

                }
            }

            else if (Check_HashBrowns.IsChecked == true)
            {

                if (this.DataContext is SmokehouseSkeleton ss)
                {
                    ss.hashBrowns = true;

                }
            }

        }
        private void Checked_Sausage(object sender, RoutedEventArgs e)
        {
            if (Check_Sausage_Link.IsChecked == false)
            {

                if (this.DataContext is SmokehouseSkeleton ss)
                {
                    ss.sausageLink = false;

                }
            }

            else if (Check_Sausage_Link.IsChecked == true)
            {

                if (this.DataContext is SmokehouseSkeleton ss)
                {
                    ss.sausageLink = true;

                }
            }

        }
        private void Checked_Pancakes(object sender, RoutedEventArgs e)
        {
            if (Check_Pancakes.IsChecked == false)
            {

                if (this.DataContext is SmokehouseSkeleton ss)
                {
                    ss.pancake = false;

                }
            }

            else if (Check_Pancakes.IsChecked == true)
            {

                if (this.DataContext is SmokehouseSkeleton ss)
                {
                    ss.pancake = true;

                }
            }

        }
        private void Checked_Broccoli(object sender, RoutedEventArgs e)
        {
            if (Check_Broccoli.IsChecked == false)
            {

                if (this.DataContext is GardenOrcOmelette ss)
                {
                    ss.broccoli = false;

                }
            }

            else if (Check_Broccoli.IsChecked == true)
            {

                if (this.DataContext is GardenOrcOmelette ss)
                {
                    ss.broccoli = true;

                }
            }

        }
        private void Checked_Cheddar(object sender, RoutedEventArgs e)
        {
            if (Check_Cheddar.IsChecked == false)
            {

                if (this.DataContext is GardenOrcOmelette ss)
                {
                    ss.cheddar = false;

                }
            }

            else if (Check_Cheddar.IsChecked == true)
            {

                if (this.DataContext is GardenOrcOmelette ss)
                {
                    ss.cheddar = true;

                }
            }

        }
        private void Checked_Tomato_Omelette(object sender, RoutedEventArgs e)
        {
            if (Check_Tomato_Omelette.IsChecked == false)
            {

                if (this.DataContext is GardenOrcOmelette ss)
                {
                    ss.tomato = false;

                }
            }

            else if (Check_Tomato_Omelette.IsChecked == true)
            {

                if (this.DataContext is GardenOrcOmelette ss)
                {
                    ss.tomato = true;

                }
            }

        }
        private void Checked_Mushrooms(object sender, RoutedEventArgs e)
        {
            if (Check_Mushrooms.IsChecked == false)
            {

                if (this.DataContext is GardenOrcOmelette ss)
                {
                    ss.mushrooms = false;

                }
            }

            else if (Check_Mushrooms.IsChecked == true)
            {

                if (this.DataContext is GardenOrcOmelette ss)
                {
                    ss.mushrooms = true;

                }
            }

        }
        private void Checked_Onion(object sender, RoutedEventArgs e)
        {
            if (Check_Onion.IsChecked == false)
            {

                if (this.DataContext is PhillyPoacher ss)
                {
                    ss.onion = false;

                }
            }

            else if (Check_Onion.IsChecked == true)
            {

                if (this.DataContext is PhillyPoacher ss)
                {
                    ss.onion = true;

                }
            }

        }
        private void Checked_Sirloin(object sender, RoutedEventArgs e)
        {
            if (Check_Sirloin.IsChecked == false)
            {

                if (this.DataContext is PhillyPoacher ss)
                {
                    ss.sirloin = false;

                }
            }

            else if (Check_Sirloin.IsChecked == true)
            {

                if (this.DataContext is PhillyPoacher ss)
                {
                    ss.sirloin = true;

                }
            }

        }
        private void Checked_Roll(object sender, RoutedEventArgs e)
        {
            if (Check_Roll.IsChecked == false)
            {

                if (this.DataContext is PhillyPoacher ss)
                {
                    ss.roll = false;

                }
            }

            else if (Check_Roll.IsChecked == true)
            {

                if (this.DataContext is PhillyPoacher ss)
                {
                    ss.roll = true;

                }
            }
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            if(this.DataContext is IOrderItem item)
            {
                if(Orderlist.DataContext is Order ThisOrder)
                ThisOrder.Add(item);
                ListBoxItem box = new ListBoxItem();
                box.Content = item;
                ListBoxItem box2 = new ListBoxItem();
                box2.Content = item.SpecialInstructions;

                
                Orderlist.Items.Add(box);
                Orderlist.Items.Add(box2);


            }
        }

        private void Button_Remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewOrder_Click(object sender, RoutedEventArgs e)
        {
            Orderlist.Items.Clear();

            if (Orderlist.DataContext is Order ThisOrder)
            {
                Orderlist.DataContext = new Order();
                ui_Number.Text = ($"Order Number #{ThisOrder.Number.ToString()}");
                ui_Total.DataContext = Orderlist.DataContext;
                ui_Tax.DataContext = Orderlist.DataContext;
                ui_Subtotal.DataContext = Orderlist.DataContext;
            }
        }

        private void ClearOrder_Click(object sender, RoutedEventArgs e)
        {
            Orderlist.Items.Clear();

            if(Orderlist.DataContext is Order Order)
            {
                Order.Clear();

            }
        }
    }

}
