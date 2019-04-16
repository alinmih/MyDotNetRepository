using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    class TransactionDateComparer : IComparer<Transaction<double>>
    {
        public int Compare(Transaction<double> x, Transaction<double> y)
        {
            if (x.TimeStamp > y.TimeStamp)
            {
                return 1;
            }
            else
                return -1;
        }
    }
}
