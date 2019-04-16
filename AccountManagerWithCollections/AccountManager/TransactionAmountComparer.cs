using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    class TransactionAmountComparer : IComparer<Transaction<double>>
    {
        public int Compare(Transaction<double> x, Transaction<double> y)
        {
            if (x.Amount > y.Amount)
            {
                return 1;
            }
            if (x.Amount < y.Amount)
            {
                return -1;
            }
            else
                return 0;
        }
    }
}
