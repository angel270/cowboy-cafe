using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyTests
{
    public class WaterProperties
    {
        //Checks if Water implements PropertyChanged
        [Fact]
        public void WaterImplementsINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        // Testing if the Ice Property invokes PropertyChanged for Ice and SpecialInstructions
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () => {
                water.Ice = false;
            });
        }
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => {
                water.Ice = false;
            });
        }

        // Testing if the Lemon Property invokes PropertyChanged for Lemon and SpecialInstructions
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () => {
                water.Lemon = true;
            });
        }
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => {
                water.Lemon = true;
            });
        }

    }
}
