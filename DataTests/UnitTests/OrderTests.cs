using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests  
{
    public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public List<string> SpecialInstructions { get; set; }
        }
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();

            order.Add(item);

            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();

            order.Add(item);
            order.Remove(item);

            Assert.DoesNotContain(item, order.Items);
        }

        [Fact]
        public void ShouldBeAbleToGetEnumerationOfItems()
        {
            var order = new Order();
            var i0 = new MockOrderItem();
            var i1 = new MockOrderItem();
            var i2 = new MockOrderItem();

            order.Add(i0);
            order.Add(i1);
            order.Add(i2);

            Assert.Collection(order.Items,
                    item => Assert.Equal(i0, item),
                    item => Assert.Equal(i1, item),
                    item => Assert.Equal(i2, item));
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0, 0.3, 0 })]
        [InlineData(new double[] { 199.34, 799 })]
        [InlineData(new double[] { 798 })]
        [InlineData(new double[] { })]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] { -4, 10, 8 })]
        [InlineData(new double[] { 3.123456789 })]
        [InlineData(new double[] { double.NaN })]
        public void SubtotalShouldBeTheSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;

            foreach (var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    Price = price
                });
            }

            Assert.Equal(total, order.Subtotal);
        }

        [Theory]
        [InlineData ("Price")]
        [InlineData ("Items")]
        public void AddingAnItemShouldTriggerPropertyChanged(String propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }

        [Theory]
        [InlineData ("Price")]
        [InlineData ("Items")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);
            });
        }
    }
}
