using VendingMachine.Models;
using Xunit;

namespace VendingMachine.Test
{
    public class FoodTest
    {
        [Fact]
        public void TestId()
        {
            Food piza = new Food(1, "Pizza", "HOT", 10);

            Assert.NotEqual(4, piza.Id);
        }

        [Fact]
        public void TestPrice()
        {
            Food meat = new Food(2, "Burgar", "Meat", 90);

            Assert.Equal(90, meat.Price);
        }

        [Fact]
        public void TestObject()
        {
            Food potato = new Food(3, "Potato Chips", "Cheeze", 12);

            Assert.IsType<Food>(potato);
        }

        [Fact]
        public void TestUse()
        {
            Food potato = new Food(4, "Potato Chips", "Cheeze", 12);

            Assert.IsNotType<int>(potato.Use());
        }

        [Fact]
        public void TestName()
        {
            Food Wine = new Food(5, "Pizza hot", "Enjoy it", 12);
            Assert.Equal("Pizza hot", Wine.Name);
        }

        [Fact]
        public void TestExime()
        {
            Food wall = new Food(6, "Pasta", "Delicase", 20);
            Assert.NotEmpty(wall.Examine());
        }

    }
}
