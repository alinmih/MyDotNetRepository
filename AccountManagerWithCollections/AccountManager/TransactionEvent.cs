/*****************************************************************************************
 * 
 * Academia Microsoft,
 * Curs: 2.NET
 * Laborator 2
 * 
 ****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManager
{
    // Custom event argument class.
    public class TransactionEventArgs : EventArgs
    {
        // Amount of the transaction is a double, for simplicity.
        private double _amount;

        // Constructor.
        public TransactionEventArgs(double a)
        {
            _amount = a;
        }

        // Get the amount of the transaction.
        public double Amount
        {
            get { return _amount; }
        }
    }
}
