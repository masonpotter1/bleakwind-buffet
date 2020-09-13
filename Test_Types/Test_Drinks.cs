using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System;
using Xunit;

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
    }
}

