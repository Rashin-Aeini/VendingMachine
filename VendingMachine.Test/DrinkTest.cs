using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Models;
using Xunit;

namespace VendingMachine.Test
{
    public class DrinkTest
    {

        [Fact]
        public void TestId()
        {
            Drink piza = new Drink(1, "Pizza", "HOT", 10);

            Assert.NotEqual(4, piza.Id);
        }

        [Fact]
        public void TestPrice()
        {
            Drink meat = new Drink(2, "Sode", "Cold", 90);

            Assert.Equal(90, meat.Price);
        }

        [Fact]
        public void TestObject()
        {
            Drink potato = new Drink(3, "Cocacola", "Energy", 12);

            Assert.IsType<Drink>(potato);
        }

        [Fact]
        public void TestUse()
        {
            Drink potato = new Drink(4, "Fanta", "Energy", 12);

            Assert.Equal("Energy", potato.Use());
        }

        [Fact]
        public void TestName()
        {
            Drink Wine = new Drink(5, "Cocacola Zero", "Red", 12);
            Assert.Equal("Cocacola Zero", Wine.Name);
        }

        [Fact]
        public void TestExime()
        {
            Drink wall = new Drink(6, "Pepsi", "Delicase", 20);
            Assert.NotEmpty(wall.Examine());
        }

    }
}
