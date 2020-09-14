using BleakwindBuffet.Data.Entrees;
using Data;
using System;
using Xunit;

namespace Test_Types
{
    public class Entrees
    {
        /// <summary>
        /// this test makes sure that all topings are defaulted to True
        /// </summary>
        [Fact]
        public void EntreeToppingsAreTrueByDefault()
        {
            BriarheartBurger Single = new BriarheartBurger();
            Assert.True(Single.bun);
            Assert.True(Single.cheese);
            Assert.True(Single.ketchup);
            Assert.True(Single.mustard);
            Assert.True(Single.pickle);
            Assert.True(Single.SpecialInstructions.Count == 0);

            DoubleDraugr Double = new DoubleDraugr();
            Assert.True(Double.bun);
            Assert.True(Double.cheese);
            Assert.True(Double.ketchup);
            Assert.True(Double.mustard);
            Assert.True(Double.pickle);
            Assert.True(Double.tomato);
            Assert.True(Double.mayo);
            Assert.True(Double.SpecialInstructions.Count == 0);

            ThalmorTriple Triple = new ThalmorTriple();
            Assert.True(Triple.bun);
            Assert.True(Triple.cheese);
            Assert.True(Triple.ketchup);
            Assert.True(Triple.mustard);
            Assert.True(Triple.pickle);
            Assert.True(Triple.tomato);
            Assert.True(Triple.mayo);
            Assert.True(Triple.bacon);
            Assert.True(Triple.egg);
            Assert.True(Triple.SpecialInstructions.Count == 0);

            GardenOrcOmelette Omelette = new GardenOrcOmelette();
            Assert.True(Omelette.broccoli);
            Assert.True(Omelette.cheddar);
            Assert.True(Omelette.mushrooms);
            Assert.True(Omelette.tomato);
            Assert.True(Omelette.SpecialInstructions.Count == 0);

            PhillyPoacher Philly = new PhillyPoacher();
            Assert.True(Philly.onion);
            Assert.True(Philly.roll);
            Assert.True(Philly.sirloin);
            Assert.True(Philly.SpecialInstructions.Count == 0);

            SmokehouseSkeleton Skelly = new SmokehouseSkeleton();
            Assert.True(Skelly.egg);
            Assert.True(Skelly.pancake);
            Assert.True(Skelly.sausageLink);
            Assert.True(Skelly.hashBrowns);
            Assert.True(Skelly.SpecialInstructions.Count == 0);

            ThugsTBone Thug = new ThugsTBone();
            Assert.True(Thug.SpecialInstructions.Count == 0);
        }
        /// <summary>
        /// This test makes sure that all toping options are able 
        /// to be removed. It also tests to make sure that 
        /// "SpecialInstructions" is being updated at the same time
        /// </summary>
        [Fact]
        public void EntreeToppingRemoved()
        {
            BriarheartBurger Single = new BriarheartBurger();
            Single.bun = false;
            Single.cheese = false;
            Single.ketchup = false;
            Single.mustard = false;
            Single.pickle = false;

            Assert.False(Single.bun);
            Assert.False(Single.cheese);
            Assert.False(Single.ketchup);
            Assert.False(Single.mustard);
            Assert.False(Single.pickle);
            Assert.True(Single.SpecialInstructions.Count == 5);

            DoubleDraugr Double = new DoubleDraugr();
            Double.bun = false;
            Double.cheese = false;
            Double.ketchup = false;
            Double.mustard = false;
            Double.pickle = false;
            Double.tomato = false;
            Double.mayo = false;

            Assert.False(Double.bun);
            Assert.False(Double.cheese);
            Assert.False(Double.ketchup);
            Assert.False(Double.mustard);
            Assert.False(Double.pickle);
            Assert.False(Double.tomato);
            Assert.False(Double.mayo);
            Assert.True(Double.SpecialInstructions.Count == 7);

            ThalmorTriple Triple = new ThalmorTriple();
            Triple.bun = false;
            Triple.cheese = false;
            Triple.ketchup = false;
            Triple.mustard = false;
            Triple.pickle = false;
            Triple.tomato = false;
            Triple.mayo = false;
            Triple.bacon = false;
            Triple.egg = false;

            Assert.False(Triple.bun);
            Assert.False(Triple.cheese);
            Assert.False(Triple.ketchup);
            Assert.False(Triple.mustard);
            Assert.False(Triple.pickle);
            Assert.False(Triple.tomato);
            Assert.False(Triple.mayo);
            Assert.False(Triple.bacon);
            Assert.False(Triple.egg);
            Assert.True(Triple.SpecialInstructions.Count == 9);

            GardenOrcOmelette Omelette = new GardenOrcOmelette();
            Omelette.broccoli = false;
            Omelette.cheddar = false;
            Omelette.mushrooms = false;
            Omelette.tomato = false;

            Assert.False(Omelette.broccoli);
            Assert.False(Omelette.cheddar);
            Assert.False(Omelette.mushrooms);
            Assert.False(Omelette.tomato);
            Assert.True(Omelette.SpecialInstructions.Count == 4);

            PhillyPoacher Philly = new PhillyPoacher();
            Philly.onion = false;
            Philly.roll = false;
            Philly.sirloin = false;

            Assert.False(Philly.onion);
            Assert.False(Philly.roll);
            Assert.False(Philly.sirloin);
            Assert.True(Philly.SpecialInstructions.Count == 3);

            SmokehouseSkeleton Skelly = new SmokehouseSkeleton();
            Skelly.egg = false;
            Skelly.pancake = false;
            Skelly.sausageLink = false;
            Skelly.hashBrowns = false;

            Assert.False(Skelly.egg);
            Assert.False(Skelly.pancake);
            Assert.False(Skelly.sausageLink);
            Assert.False(Skelly.hashBrowns);
            Assert.True(Skelly.SpecialInstructions.Count == 4);

            ThugsTBone Thug = new ThugsTBone();
            Assert.True(Thug.SpecialInstructions.Count == 0);

            
            
        }


        /// <summary>
        /// The next set of tests Try all the Drink "ToString" Methods
        /// </summary>

        [Fact]
        public void SingleToString()
        {
            var side = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", side.ToString());
        }
        [Fact]
        public void DoubleToString()
        {
            var side = new DoubleDraugr();
            Assert.Equal("Double Draugr", side.ToString());
        }
        [Fact]
        public void TripleToString()
        {
            var side = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", side.ToString());
        }
        [Fact]
        public void OmeletteToString()
        {
            var side = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", side.ToString());
        }
        [Fact]
        public void PhillyToString()
        {
            var side = new PhillyPoacher();
            Assert.Equal("Philly Poacher", side.ToString());
        }
        [Fact]
        public void TboneToString()
        {
            var side = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", side.ToString());
        }
        [Fact]
        public void SmokehouseToString()
        {
            var side = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", side.ToString());
        }

        /// <summary>
        /// Tests to make sure all entrees are inharented to the "Entree" class
        /// </summary>
        [Fact]
        public void ShouldBeEntree()
        {
            BriarheartBurger br = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette oo = new GardenOrcOmelette();
            PhillyPoacher ph = new PhillyPoacher();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone tb = new ThugsTBone();

            Assert.IsAssignableFrom<Entree>(br);
            Assert.IsAssignableFrom<Entree>(dd);
            Assert.IsAssignableFrom<Entree>(oo);
            Assert.IsAssignableFrom<Entree>(ph);
            Assert.IsAssignableFrom<Entree>(tt);
            Assert.IsAssignableFrom<Entree>(tb);
        }
        /// <summary>
        /// Tests to make sure items can be an IOrderItem
        /// </summary>
        [Fact]
        public void CanBeIOrderItem()
        {
            BriarheartBurger br = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette oo = new GardenOrcOmelette();
            PhillyPoacher ph = new PhillyPoacher();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone tb = new ThugsTBone();

            Assert.IsAssignableFrom<IOrderItem>(br);
            Assert.IsAssignableFrom<IOrderItem>(dd);
            Assert.IsAssignableFrom<IOrderItem>(oo);
            Assert.IsAssignableFrom<IOrderItem>(ph);
            Assert.IsAssignableFrom<IOrderItem>(tt);
            Assert.IsAssignableFrom<IOrderItem>(tb);
        }
    }
}
