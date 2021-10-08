using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public class Kron : Wallet
    {
        public override List<int> Denominations
        {
            get
            {
                return new List<int>
                {
                    1,
                    5,
                    10,
                    20, 
                    50,
                    100,
                    500,
                    1000
                };
            }
        }
    }
}
