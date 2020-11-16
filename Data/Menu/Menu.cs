using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// this is a class that represnets a menu item
    /// </summary>
    public static class Menu
    {
        public static List<IOrderItem> entrees = new List<IOrderItem>();

        public static IEnumerable<IOrderItem> AllEntrees { get { return Entrees(); } }

        /// <summary>
        /// adds all entrees to the menu
        /// </summary>
        /// <returns> returns a list of all entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        { 
            List<IOrderItem> entreeList = new List<IOrderItem>();
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette gc = new GardenOrcOmelette();
            PhillyPoacher ph = new PhillyPoacher();
            SmokehouseSkeleton sh = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone tb = new ThugsTBone();
            entreeList.Add(bb);
            entreeList.Add(dd);
            entreeList.Add(gc);
            entreeList.Add(ph);
            entreeList.Add(sh);
            entreeList.Add(tt);
            entreeList.Add(tb);

            return (entreeList);
        }

        public static IEnumerable<IOrderItem> AllDrinks { get { return Drinks(); } }
        /// <summary>
        /// adds all drinks to the menu
        /// </summary>
        /// <returns>returns a list of all drinks </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> Drinklist = new List<IOrderItem>();

            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                aj.Size = s;
                Drinklist.Add(aj);

                foreach(SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = s;
                    ss.flavor = f;
                    Drinklist.Add(ss);
                }
                CandlehearthCoffee cf = new CandlehearthCoffee();
                cf.Size = s;
                Drinklist.Add(cf);
                CandlehearthCoffee dcf = new CandlehearthCoffee();
                dcf.Size = s;
                dcf.decaf = true;
                Drinklist.Add(dcf);

                MarkarthMilk mm = new MarkarthMilk();
                mm.Size = s;
                Drinklist.Add(mm);

                WarriorWater ww = new WarriorWater();
                ww.Size = s;
                Drinklist.Add(ww);

            }
            return Drinklist;
        }

        public static IEnumerable<IOrderItem> AllSides { get { return Sides(); } }
        /// <summary>
        /// adds all sides to the list
        /// </summary>
        /// <returns>returns a list of all sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> Sidelist = new List<IOrderItem>();

            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries df = new DragonbornWaffleFries();
                df.Size = s;
                FriedMiraak fm = new FriedMiraak();
                fm.Size = s;
                MadOtarGrits mo = new MadOtarGrits();
                mo.Size = s;
                VokunSalad vs = new VokunSalad();
                vs.Size = s;

                Sidelist.Add(df);
                Sidelist.Add(fm);
                Sidelist.Add(mo);
                Sidelist.Add(vs);
            }
            return Sidelist;

        }
        public static IEnumerable<IOrderItem> AllItems { get { return FullMenue(); } }

        public static IEnumerable<IOrderItem> FullMenue()
        {
            List<IOrderItem> menuItems = new List<IOrderItem>();
            menuItems.AddRange(Entrees());
            menuItems.AddRange(Drinks());
            menuItems.AddRange(Sides());

            return menuItems;

        }


        public static IEnumerable<IOrderItem> Search(string terms)
        {/// null check
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null)
            {
                return FullMenue();  
            }
            /// adds the item to the list 
            foreach (IOrderItem item in AllItems)
            {
                if (item is Entree e)
                {
                    if (e.ToString().Contains(terms))
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }
    }
}
