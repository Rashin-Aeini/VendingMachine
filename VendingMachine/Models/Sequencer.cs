using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public class Sequencer
    {
        private int _counter;

        public int Next()
        {
            return ++_counter;
        }

        public void Clear()
        {
            _counter = 0;
        }
    }
}
