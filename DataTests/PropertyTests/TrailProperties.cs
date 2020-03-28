using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyTests
{
    public class TrailProperties
    {
        //Checks if TrailBurger implements PropertyChanged
        [Fact]
        public void TrailBurgerImplementsINotifyPropertyChanged()
        {
            var burger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        // Testing if the Bun Property invokes PropertyChanged for Bun and SpecialInstructions
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBun()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Bun", () => {
                burger.Bun = false;
            });
        }
        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Bun = false;
            });
        }

        // Testing if the Ketchup Property invokes PropertyChanged for Ketchup and SpecialInstructions
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForKetchup()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Ketchup", () => {
                burger.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Ketchup = false;
            });
        }

        // Testing if the Mustard Property invokes PropertyChanged for Mustard and SpecialInstructions
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForMustard()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Mustard", () => {
                burger.Mustard = false;
            });
        }
        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Mustard = false;
            });
        }

        // Testing if the Pickle Property invokes PropertyChanged for Pickle and SpecialInstructions
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Pickle", () => {
                burger.Pickle = false;
            });
        }
        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Pickle = false;
            });
        }

        // Testing if the Cheese Property invokes PropertyChanged for Cheese and SpecialInstructions
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForCheese()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Cheese", () => {
                burger.Cheese = false;
            });
        }
        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => {
                burger.Cheese = false;
            });
        }

    }
}
