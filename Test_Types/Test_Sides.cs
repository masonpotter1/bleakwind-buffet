using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using Xunit;

namespace Test_Types
{
    public class Test_Sides
    {
        
        [Theory]
        [InlineData(Size.Small, .93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void VokunCost(Size size, double cost)
        {
            var Side = new VokunSalad();
            Side.orderSize = size;
            Assert.Equal(cost, Side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void VokunCals(Size size, uint cal)
        {
            var Side = new VokunSalad();
            Side.orderSize = size;
            Assert.Equal(cal, Side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void GritsCost(Size size, double cost)
        {
            var Side = new MadOtarGrits();
            Side.orderSize = size;
            Assert.Equal(cost, Side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void GritsCals(Size size, uint cal)
        {
            var Side = new MadOtarGrits();
            Side.orderSize = size;
            Assert.Equal(cal, Side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void FriedMiraakCost(Size size, double cost)
        {
            var Side = new FriedMiraak();
            Side.orderSize = size;
            Assert.Equal(cost, Side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void FriedMiraakCals(Size size, uint cal)
        {
            var Side = new FriedMiraak();
            Side.orderSize = size;
            Assert.Equal(cal, Side.Calories);
        }

        [Theory]
        [InlineData(Size.Small, .42)]
        [InlineData(Size.Medium, .76)]
        [InlineData(Size.Large, .96)]
        public void DragonBornCost(Size size, double cost)
        {
            var Side = new DragonbornWaffleFries();
            Side.orderSize = size;
            Assert.Equal(cost, Side.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void DragonbornCal(Size size, uint cal)
        {
            var Side = new DragonbornWaffleFries();
            Side.orderSize = size;
            Assert.Equal(cal, Side.Calories);
        }


        /// <summary>
        /// The next set of tests Try all the Drink "ToString" Methods
        /// </summary>

        [Fact]
        public void FriesToString()
        {
            var side = new DragonbornWaffleFries();
            Assert.Equal("Small Dragonborn Waffle Fries", side.ToString());

        }

        [Fact]
        public void FriedToString()
        {
            var side = new FriedMiraak();
            Assert.Equal("Small Fried Miraak", side.ToString());

        }
        [Fact]
        public void MadToString()
        {
            var side = new MadOtarGrits();
            Assert.Equal("Small Mad Otar Grits", side.ToString());

        }
        [Fact]
        public void SaladToString()
        {
            var side = new VokunSalad();
            Assert.Equal("Small Vokun Salad", side.ToString());

        }




    }
}
