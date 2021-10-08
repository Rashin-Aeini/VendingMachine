using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Models;
using Xunit;

namespace VendingMachine.Test
{
    public class IVendingTest
    {
        [Fact]
        public void MoneyInsertTestWithThrow()
        {
            IVending vending = new Machine();
            Assert.Throws<ArgumentException>(() => { vending.InsertMoney(35); });

        }

        [Fact]
        public void InsertMoneyTest()
        {
            IVending vending = new Machine();
            for (int index = 0; index < 10; index++)
            {
                vending.InsertMoney(20);
            }
            //Assert.Equal(1, vending.EndTransaction().Count);
            Assert.Equal(
                new Dictionary<int, int> { { 100, 2 } }, 
                vending.EndTransaction()
            );

        }

        [Fact]
        public void EndTransactionTest()
        {
            IVending vending = new Machine();
            vending.InsertMoney(20);

            Assert.NotNull(vending.EndTransaction());
        }

        [Fact]
        public void ShowAllTest()
        {
            IVending vending = new Machine();
            Assert.Equal(15, vending.ShowAll().Count);
        }

        [Fact]
        public void PurchaseTest()
        {
            IVending vending = new Machine();
            Assert.Null(vending.Purchase(5));
        }


    }
}
