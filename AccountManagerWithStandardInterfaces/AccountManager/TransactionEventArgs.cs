using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    public class TransactionEventArgs: EventArgs
    {
        private double _amount;
        public TransactionEventArgs(double am)
        {
            _amount = am;
        }

        public double Amount
        {
            get
            {
                return _amount;
            }
        }
    }
}
