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
    // The Transaction structure represents a debit or credit transaction for a bank account.
    public struct Transaction<T> : IFormattable, IComparable<Transaction<T>>
          where T : IComparable<T>
    {
        // Amount and timestamp instance variables.
        private T _amount;
        private DateTime _timestamp;

        // Constructor.
        public Transaction(T amt, DateTime ts)
        {
            _amount = amt;
            _timestamp = ts;
        }

        // Override the ToString method from System.Object.
        public override string ToString()
        {
            return String.Format("{0}, {1:c}", _timestamp.ToString(), _amount);
        }

        // Get the amount of the transaction.
        public T Amount
        {
            get { return _amount; }
        }

        // Get the timestamp of the transaction.
        public DateTime TimeStamp
        {
            get { return _timestamp; }
        }

        #region IFormattable Members

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
                return this.ToString();
            else if (format == "d")
                return String.Format("{0}", _timestamp.ToString());
            else if (format == "a")
                return String.Format("{0:c}", _amount);
            else
                throw new FormatException(
                    String.Format("Invalid format: '{0}'.", format));
        }

        #endregion

        #region IComparable<Transaction<T>> Members

        public int CompareTo(Transaction<T> other)
        {
            return this._amount.CompareTo(other._amount);
        }

        #endregion
    }
}
