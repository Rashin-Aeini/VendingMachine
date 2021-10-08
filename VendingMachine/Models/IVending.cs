using System.Collections.Generic;

namespace VendingMachine.Models
{
    public interface IVending
    {
        Product Purchase(int id);
        List<Product> ShowAll();
        void InsertMoney(int money);
        IDictionary<int, int> EndTransaction();
    }
}
