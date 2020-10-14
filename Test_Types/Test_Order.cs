using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Data;
using System;
using Xunit;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace Test_Types
{
    public class Test_Order
    {
        [Fact]
        public void StartingValuesAreZero()
        {
            var Order = new Order();
            Assert.True(Order.Total == 0);
            Assert.True(Order.Count == 0);
            Assert.True(Order.Calories == 0);
            Assert.True(Order.Tax == 0);
            Assert.True(Order.Subtotal == 0);
            Assert.True(Order.Number == 1);

        }

        [Fact]
        public void CanAdd()
        {
            var Order = new Order();
            var Thing = new AretinoAppleJuice();
            Order.Add(Thing);
            Assert.True(Order.Contains(Thing) ==true);
        }

        [Fact]
        public void CanRemove()
        {
            var Order = new Order();
            var Thing = new AretinoAppleJuice();
            Order.Add(Thing);
            Assert.True(Order.Remove(Thing));
        }

        [Fact]
        public void ClearList()
        {
            var Order = new Order();
            var Thing = new AretinoAppleJuice();
            var Stuff = new BriarheartBurger();
            var That = new DragonbornWaffleFries();
            Order.Add(Thing);
            Order.Add(Stuff);
            Order.Add(That);

            Order.Clear();
            Assert.Empty(Order);

        }

        
        
    }
}
