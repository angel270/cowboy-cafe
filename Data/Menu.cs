using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Gets all the entrees on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees 
        {
            get
            {
                yield return new AngryChicken();
                yield return new CowpokeChili();
                yield return new DakotaDoubleBurger();
                yield return new PecosPulledPork();
                yield return new RustlersRibs();
                yield return new TexasTripleBurger();
                yield return new TrailBurger();
            } 
        }

        /// <summary>
        /// Gets all the sides on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Sides 
        { 
            get 
            {
                yield return new BakedBeans();
                yield return new ChiliCheeseFries();
                yield return new CornDodgers();
                yield return new PanDeCampo();
            } 
        }

        /// <summary>
        /// Gets all the drinks on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks 
        {
            get 
            {
                yield return new CowboyCoffee();
                yield return new JerkedSoda();
                yield return new TexasTea();
                yield return new Water();
            }
        }

        /// <summary>
        /// Gets all the items on the menu
        /// </summary>
        public static IEnumerable<IOrderItem> CompleteMenu
        {
            get
            {
                yield return new AngryChicken();
                yield return new CowpokeChili();
                yield return new DakotaDoubleBurger();
                yield return new PecosPulledPork();
                yield return new RustlersRibs();
                yield return new TexasTripleBurger();
                yield return new TrailBurger();

                yield return new BakedBeans();
                yield return new ChiliCheeseFries();
                yield return new CornDodgers();
                yield return new PanDeCampo();

                yield return new CowboyCoffee();
                yield return new JerkedSoda();
                yield return new TexasTea();
                yield return new Water();
            }
        }
    }
}
