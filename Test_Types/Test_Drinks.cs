using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Data;
using System;
using Xunit;
using System.ComponentModel;

namespace Test_Types
{
   public class Test_Drinks 
    {
        [Fact]
        public void DrinkPropertyDefaults()
        {
            WarriorWater water = new WarriorWater();
            Assert.Equal(Size.Small, water.Size);
            Assert.True(water.ice);
            Assert.False(water.lemon);
            Assert.True(water.SpecialInstructions.Count == 0);

            SailorSoda soda = new SailorSoda();
            Assert.Equal(Size.Small, soda.Size);
            Assert.Equal(SodaFlavor.Cherry, soda.flavor);
            Assert.True(soda.ice);
            Assert.True(soda.SpecialInstructions.Count == 0);

            MarkarthMilk milk = new MarkarthMilk();
            Assert.Equal(Size.Small, milk.Size);
            Assert.False(milk.ice);
            Assert.True(milk.SpecialInstructions.Count == 0);

            CandlehearthCoffee Coffee = new CandlehearthCoffee();
            Assert.Equal(Size.Small, Coffee.Size);
            Assert.False(Coffee.decaf);
            Assert.False(Coffee.roomForCream);
            Assert.False(Coffee.ice);
            Assert.True(Coffee.SpecialInstructions.Count == 0);

            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
            Assert.False(aj.ice);
            Assert.True(aj.SpecialInstructions.Count == 0);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void WaterCals(Size size, uint cal)
        {
            var Drink = new WarriorWater();
            Drink.Size = size;
            Assert.Equal(cal, Drink.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void WaterCost(Size size, double cost)
        {
            var Drink = new WarriorWater();
            Drink.Size = size;
            
            Assert.Equal(cost, Drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void SodaCals(Size size, uint cal)
        {
            var Drink = new SailorSoda();
            Drink.Size = size;
            Assert.Equal(cal, Drink.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void SodaCost(Size size, double cost)
        {
            var Drink = new SailorSoda();
            Drink.Size = size;

            Assert.Equal(cost, Drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void MilkCals(Size size, uint cal)
        {
            var Drink = new MarkarthMilk();
            Drink.Size = size;
            Assert.Equal(cal, Drink.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void MilkCost(Size size, double cost)
        {
            var Drink = new MarkarthMilk();
            Drink.Size = size;

            Assert.Equal(cost, Drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void CoffeeCals(Size size, uint cal)
        {
            var Drink = new CandlehearthCoffee();
            Drink.Size = size;
            Assert.Equal(cal, Drink.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void CoffeeCost(Size size, double cost)
        {
            var Drink = new CandlehearthCoffee();
            Drink.Size = size;

            Assert.Equal(cost, Drink.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void AJCals(Size size, uint cal)
        {
            var Drink = new AretinoAppleJuice();
            Drink.Size = size;
            Assert.Equal(cal, Drink.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, .87)]
        [InlineData(Size.Large, 1.01)]
        public void AJCost(Size size, double cost)
        {
            var Drink = new AretinoAppleJuice();
            Drink.Size = size;

            Assert.Equal(cost, Drink.Price);
        }
        /// <summary>
        /// The next set of tests Try all the Drink "ToString" Methods
        /// </summary>
        [Fact]
        public void AJToString()
        {
            var side = new AretinoAppleJuice();
            Assert.Equal("Small Aretino Apple Juice", side.ToString());
        }
        [Fact]
        public void CoffeeToString()
        {
            var side = new CandlehearthCoffee();
            Assert.Equal("Small Candlehearth Coffee", side.ToString());
        }
        [Fact]
        public void MilkToString()
        {
            var side = new MarkarthMilk();
            Assert.Equal("Small Markarth Milk", side.ToString());
        }
        [Fact]
        public void SodaToString()
        {
            var side = new SailorSoda();
            Assert.Equal("Small Cherry Sailor Soda", side.ToString());
        }
        [Fact]
        public void WaterToString()
        {
            var side = new WarriorWater();
            Assert.Equal("Small Warrior Water", side.ToString());
        }
        /// <summary>
        /// These tests insure all drinks inherate the Drinks class
        /// </summary>
        [Fact]
        public void ShouldAllBeDrinks()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            CandlehearthCoffee cf = new CandlehearthCoffee();
            MarkarthMilk mk = new MarkarthMilk();
            SailorSoda sd = new SailorSoda();
            WarriorWater wd = new WarriorWater();

            Assert.IsAssignableFrom<Drinks>(aj);
            Assert.IsAssignableFrom<Drinks>(cf);
            Assert.IsAssignableFrom<Drinks>(mk);
            Assert.IsAssignableFrom<Drinks>(sd);
            Assert.IsAssignableFrom<Drinks>(wd);
        }

        /// <summary>
        /// Makes sure all drinks can be an IOrderItem
        /// </summary>
        [Fact]
        public void CanBeIOrderItem()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            CandlehearthCoffee cf = new CandlehearthCoffee();
            MarkarthMilk mk = new MarkarthMilk();
            SailorSoda sd = new SailorSoda();
            WarriorWater wd = new WarriorWater();

            Assert.IsAssignableFrom<IOrderItem>(aj);
            Assert.IsAssignableFrom<IOrderItem>(cf);
            Assert.IsAssignableFrom<IOrderItem>(mk);
            Assert.IsAssignableFrom<IOrderItem>(sd);
            Assert.IsAssignableFrom<IOrderItem>(wd);
        }


        /// <summary>
        /// makes sure that all classes take the InotifyPropertyChange Interface
        /// </summary>
        [Fact]
        public void ClassIsImplmented()
        {

            AretinoAppleJuice aj = new AretinoAppleJuice();
            CandlehearthCoffee cf = new CandlehearthCoffee();
            MarkarthMilk mk = new MarkarthMilk();
            SailorSoda sd = new SailorSoda();
            WarriorWater wd = new WarriorWater();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cf);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mk);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(sd);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(wd);

        }
        /// <summary>
        /// checks the ice property of drinks
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            AretinoAppleJuice AJ = new AretinoAppleJuice();
            CandlehearthCoffee cf = new CandlehearthCoffee();
            MarkarthMilk mk = new MarkarthMilk();
            SailorSoda sd = new SailorSoda();
            WarriorWater wd = new WarriorWater();

            // those with default true Ice 
            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.ice = true;
            });
            Assert.PropertyChanged(cf, "Ice", () =>
            {
                cf.ice = true;
            });
            Assert.PropertyChanged(mk, "Ice", () =>
            {
                mk.ice = true;
            });
            Assert.PropertyChanged(sd, "Hold Ice", () =>
            {
                sd.ice = false;
            });
            Assert.PropertyChanged(wd, "Hold Ice", () =>
            {
                wd.ice = false;
            });

            // Default False Ice
            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.ice = false;
            });
            Assert.PropertyChanged(cf, "Ice", () =>
            {
                cf.ice = false;
            });
            Assert.PropertyChanged(mk, "Ice", () =>
            {
                mk.ice = false;
            });
            Assert.PropertyChanged(sd, "Hold Ice", () =>
            {
                sd.ice = true;
            });
            Assert.PropertyChanged(wd, "Hold Ice", () =>
            {
                wd.ice = true;
            });
        }

        [Fact]
        public void ChecksMisDrinkProperties()
        {
            AretinoAppleJuice AJ = new AretinoAppleJuice();
            CandlehearthCoffee cf = new CandlehearthCoffee();
            MarkarthMilk mk = new MarkarthMilk();
            SailorSoda sd = new SailorSoda();
            WarriorWater wd = new WarriorWater();

            Assert.PropertyChanged(cf, "Decaf", () =>
            {
                cf.decaf = true;
            });
            Assert.PropertyChanged(cf, "Cream", () =>
            {
                cf.roomForCream = true;
            });

            Assert.PropertyChanged(cf, "Decaf", () =>
            {
                cf.decaf = false;
            });
            Assert.PropertyChanged(cf, "Cream", () =>
            {
                cf.roomForCream = false;
            });

            Assert.PropertyChanged(wd, "Add lemon", () =>
            {
                wd.lemon = true;
            });
            Assert.PropertyChanged(wd, "Add lemon", () =>
            {
                wd.lemon = false;
            });
        }
        /// <summary>
        /// Checks to make sure soda flavors change
        /// </summary>
        /// <param name="x"></param>
        [Theory]
        [InlineData (SodaFlavor.Cherry)]
        [InlineData(SodaFlavor.Blackberry)]
        [InlineData(SodaFlavor.Grapefruit)]
        [InlineData(SodaFlavor.Lemon)]
        [InlineData(SodaFlavor.Peach)]
        [InlineData(SodaFlavor.Watermelon)]
        public void DrinkFlavorChanges(SodaFlavor x)
        {
            var Soda = new SailorSoda();
            Assert.PropertyChanged(Soda, $"{x}", () =>
            {
                Soda.flavor = x;
            });
        }


        [Fact]
        public void SodaDescription()
        {
            var Item = new SailorSoda();
            Assert.Equal("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", Item.Description);
        }
        [Fact]
        public void MilkDescription()
        {
            var Item = new MarkarthMilk();
            Assert.Equal("Hormone-free organic 2% milk.", Item.Description);
        }
        [Fact]
        public void JuiceDescription()
        {
            var Item = new AretinoAppleJuice();
            Assert.Equal("Fresh squeezed apple juice.", Item.Description);
        }
        [Fact]
        public void CoffeeDescription()
        {
            var Item = new CandlehearthCoffee();
            Assert.Equal("Fair trade, fresh ground dark roast coffee.", Item.Description);
        }
        [Fact]
        public void WaterDescription()
        {
            var Item = new WarriorWater();
            Assert.Equal("It’s water. Just water.", Item.Description);
        }

    }
}

