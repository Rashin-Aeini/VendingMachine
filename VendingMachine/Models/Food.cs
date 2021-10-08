using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public class Food : Product
    {
        private string _message;
        public Food(int id, string name, string message, int price) : base(id, name, price)
        {
            _message = message;
        }

        public string Recipe { get; set; }

        public override string Examine()
        {
            return $"{Id}.{Name} ===> {Price}";
        }

        public override string Use()
        {
            return _message;
        }
    }
}
