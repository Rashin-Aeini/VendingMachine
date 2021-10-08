using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Models;
using Xunit;

namespace VendingMachine.Test
{
    public class ToyTest
    {
        [Fact]
        public void TestId()
        {
            Toy Bear = new Toy(1, "Bear", "Valantine", 500);

            Assert.IsType<int>(Bear.Id);

        }

        [Fact]
        public void TestPrice()
        {
            Toy ball = new Toy(2, "Ball", "Play Soccer", 90);

            Assert.Equal(90, ball.Price);
        }

        [Fact]
        public void TestObject()
        {
            Toy Doll = new Toy(3, "Doll", "Red Dool", 12);
            Assert.NotNull(Doll);
        }

        [Fact]
        public void TestUse()
        {
            Toy Baloon = new Toy(4, "Baloon", "Blue", 12);
            Assert.Equal("Blue", Baloon.Use());
        }

        [Fact]
        public void TestName()
        {
            Toy Rattle = new Toy(5, "Rattle", "Sound good", 12);
            Assert.IsNotType<bool>(Rattle.Name);
        }

        [Fact]
        public void TestExime()
        {
            Toy wall = new Toy(6, "Logo wall", "Be creative", 20);
            Assert.NotEmpty(wall.Examine());
        }

    }
}
