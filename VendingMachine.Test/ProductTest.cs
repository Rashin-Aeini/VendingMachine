using System;
using VendingMachine.Models;
using Xunit;

namespace VendingMachine.Test
{
    public class ProductTest
    {
        [Fact]
        public void TestId()
        {
            Product soda = new Drink(1, "Soda", "Drink cool", 10);

            //soda.Adult = false

            Assert.Equal(1, soda.Id);

        }

        [Fact]
        public void TestPrice()
        {
            Product ball = new Toy(2, "Ball", "Play Soccer", 90);

            Assert.Equal(90, ball.Price);
        }

        [Fact]
        public void TestObject()
        {
            Product potato = new Food(3, "Potato Chips", "Cheeze", 12);
            Assert.NotNull(potato);
        }

        [Fact]
        public void TestUse()
        {
            Product potato = new Food(4, "Potato Chips", "Cheeze", 12);
            Assert.NotNull(potato.Use());
        }

        [Fact]
        public void TestName()
        {
            Product Wine = new Drink(5, "Wine", "Red", 12);
            Assert.Equal("Wine", Wine.Name);
        }

        [Fact]
        public void TestExime()
        {
            Product wall = new Toy(6, "Logo wall", "Be creative", 20);
            Assert.NotEmpty(wall.Examine());
        }


    }
}
