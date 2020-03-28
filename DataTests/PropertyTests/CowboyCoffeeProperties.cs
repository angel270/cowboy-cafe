using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyTests
{
    public class CowboyCoffeeProperties
    {
        //Checks if CowboyCoffee implements PropertyChanged
        [Fact]
        public void CowboyCoffeeImplementsINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        // Testing if the Size Property invokes PropertyChanged for Size, Price, and Calories
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForSize()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () => {
                coffee.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Price", () => {
                coffee.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForCalories()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Calories", () => {
                coffee.Size = Size.Medium;
            });
        }

        // Testing if the RFC Property invokes PropertyChanged for RFC and SpecialInstructions
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () => {
                coffee.RoomForCream = true;
            });
        }
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => {
                coffee.RoomForCream = true;
            });
        }

        // Testing if the Decaf Property invokes PropertyChanged for Decaf and SpecialInstructions
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () => {
                coffee.Decaf = true;
            });
        }
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => {
                coffee.Decaf = true;
            });
        }

        // Testing if the Ice Property invokes PropertyChanged for Ice and SpecialInstructions
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () => {
                coffee.Ice = true;
            });
        }
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => {
                coffee.Ice = true;
            });
        }

    }
}
