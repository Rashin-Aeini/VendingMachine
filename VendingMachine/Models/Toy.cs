using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public class Toy : Product
    {
        public Toy(int id, string name, string message, int price) : base(id, name, price)
        {
            Message = message;
        }

        public int Age { get; set; }
        public string Message { get; set; }

        public override string Examine()
        {
            return $"{Id}.{Name} ===> {Price}";
        }

        public override string Use()
        {
            return Message;
        }
    }
}
