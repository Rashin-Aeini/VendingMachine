using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public abstract class Product
    {
        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; }
        public string Name { get; }
        public int Price { get; }

        public virtual string Examine()
        {
            return $"{GetType().Name}:{Id}.{Name} === > {Price}";
        }
        public abstract string Use();
    }
}
