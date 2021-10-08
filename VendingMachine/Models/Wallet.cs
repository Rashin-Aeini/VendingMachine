using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public abstract class Wallet
    {
        public abstract List<int> Denominations { get; }


        private int _amount;

        public void Add(int value)
        {
            bool find = false;
            foreach (int item in Denominations)
            {
                if(value == item)
                {
                    _amount += value;
                    find = true;
                    break;
                }
            }
            if (!find)
            {
                throw new ArgumentException("Please insert correct money");
            }
        }

        public void Decrease(int value)
        {
            _amount -= value;
        }

        public void Clear()
        {
            _amount = 0;
        }
        
        public int Amount()
        {
            return _amount;
        }

    }
}
