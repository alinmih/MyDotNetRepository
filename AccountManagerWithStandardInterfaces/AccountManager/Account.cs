/*****************************************************************************************
 * 
 * Academia Microsoft,
 * Curs: 2.NET
 * Laborator 1
 * 
 ****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    // The Account class represents a bank account.
    public class Account
    {
        //events
        public event EventHandler<TransactionEventArgs> LargeDebit;
        public event EventHandler<TransactionEventArgs> LargeCredit;

        // Name and balance of the bank account.
        private string _name;
        private double _balance;

        // Transaction information.
        private Transaction<double>? _mostRecentTransaction;
        private List<Transaction<double>> _allTransactions = new List<Transaction<double>>();

        // Constructor.
        public Account(string name)
        {
            _name = name;
            _balance = 0;
            _mostRecentTransaction = null;
        }

        // Deposit money into the account.
        public void Deposit(double amount)
        {
            _balance += amount;

            Transaction<double> trans = new Transaction<double>(amount, DateTime.Now);
            
            _mostRecentTransaction = trans;
            _allTransactions.Add(trans);

            if(amount >= 1000)
            {
                EventHandler<TransactionEventArgs> handler = LargeCredit;
                if(handler != null)
                {
                    TransactionEventArgs args = new TransactionEventArgs(amount);
                    handler(this, args);
                }
            }
        }

        // Withdraw money from the account.
        public void Withdraw(double amount)
        {
            if(_balance < 0)
            {
                string message = String.Format("Cannot withdraw {0:c} from {1}", amount, _name);
                throw new TransactionException(message);
            }
            _balance -= amount;

            Transaction<double> trans = new Transaction<double>(-amount, DateTime.Now);

            _mostRecentTransaction = trans;
            _allTransactions.Add(trans);

            if(amount >= 1000)
            {
                EventHandler<TransactionEventArgs> handler = LargeDebit;
                if(handler!= null)
                {
                    TransactionEventArgs args = new TransactionEventArgs(amount);
                    handler(this, args);
                }
            }
        }

        // Return a string representation of an account.
        public override string ToString()
        {
            if (_mostRecentTransaction.HasValue)
            {
                return string.Format(
                "{0}, balance: {1:c}, most recent transaction: {2}",
                _name,
                _balance,
                _mostRecentTransaction);

            }
            else
            {
                return string.Format("No recent transcations");
            }
        }


        // Get all transactions.
        public Transaction<double>[] AllTransactions
        {
            get
            {
                Transaction<double>[] copy = _allTransactions.ToArray();
                Array.Sort(copy);
                return copy;
            }
        }
    }
}
