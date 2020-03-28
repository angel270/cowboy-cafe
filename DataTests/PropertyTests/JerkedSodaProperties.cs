using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyTests
{
    public class JerkedSodaProperties
    {
        //Checks if JerkedSoda implements PropertyChanged
        [Fact]
        public void JerkedSodaImplementsINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }
        // Testing if the Size Property invokes PropertyChanged for Flavor, Size, Price, and Calories
        [Fact]
        public void ChangingFlavorPropertyShouldInvokePropertyChangedForFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () => {
                soda.Flavor = SodaFlavor.Sarsparilla;
            });
        }
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () => {
                soda.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () => {
                soda.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () => {
                soda.Size = Size.Medium;
            });
        }

        // Testing if the Ice Property invokes PropertyChanged for Ice and SpecialInstructions
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () => {
                soda.Ice = false;
            });
        }
            [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () => {
                soda.Ice = false;
            });
        }

    }
}
