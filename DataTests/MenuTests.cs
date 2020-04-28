using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {
        // Sides Should Contain all Entree Items
        [Fact]
        public void MenuShouldContainExpectedEntrees()
        {
            var entrees = new List<IOrderItem>(Menu.Entrees);
            entrees.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        // Sides Should Contain ChiliCheeseFries, BakedBeans, CornDodgers, and PanDeCampo
        [Fact]
        public void MenuShouldContainExpectedSides()
        {
            var sides = new List<IOrderItem>(Menu.Sides);
            sides.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                sides,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        // Sides Should Contain CowboyCoffee, JerkedSoda, TexasTea, Water
        [Fact]
        public void MenuShouldContainExpectedDrinks()
        {
            var drinks = new List<IOrderItem>(Menu.Drinks);
            drinks.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                drinks,
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        // Tests the Search Method
        [Theory]
        [InlineData("Love")]
        [InlineData("Happy")]
        [InlineData("22")]
        [InlineData("@")]
        [InlineData(null)]
        public void SearchShouldReturnExpectedResults(string terms)
        {
            IEnumerable<IOrderItem> items = Menu.CompleteMenu;
            IEnumerable<IOrderItem> items2 = Menu.CompleteMenu;
            items = Menu.Search(terms);
            Assert.NotEqual(items2, items);
        }
        

        // Tests the FilterByCalories Method
        [Theory]
        [InlineData((uint)0, (uint)0)]
        [InlineData((uint)600, (uint)750)]
        [InlineData(null, (uint)600)]
        [InlineData((uint)700, null)]
        [InlineData(null, null)]
        public void FilterByCaloriesShouldReturnExpectedResults(uint? min, uint? max)
        {
            IEnumerable<IOrderItem> items = Menu.CompleteMenu;
            IEnumerable<IOrderItem> items2 = Menu.CompleteMenu;
            items = Menu.FilterByCalories(items, min, max);
            Assert.NotEqual(items, items2);
        }

        // Tests the FilterByPrice Method
        [Theory]
        [InlineData(0.0, 0.0)]
        [InlineData(5.0, 6.0)]
        [InlineData(null, 6.0)]
        [InlineData(5.0, null)]
        [InlineData(null, null)]
        [InlineData(Double.NaN, Double.NaN)]
        [InlineData(-5.0, -6.0)]
        public void FilterByPriceShouldReturnExpectedResults(double? min, double? max)
        {
            IEnumerable<IOrderItem> items = Menu.CompleteMenu;
            IEnumerable<IOrderItem> items2 = Menu.CompleteMenu;
            items = Menu.FilterByPrice(items, min, max);
            Assert.NotEqual(items, items2);
        }

    }
}
