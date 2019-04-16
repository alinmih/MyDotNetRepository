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
    // The Transaction structure represents a debit or credit transaction for a bank account.
    public struct Transaction<T> : IComparable<Transaction<T>>, IFormattable
        where T:IComparable<T>
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

        public int CompareTo(Transaction<T> other)
        {
            return this._amount.CompareTo(other._amount);
        }


        // Override the ToString method from System.Object.
        public override string ToString()
        {
            return String.Format(
                "{0}, {1:c}",
                 _timestamp.ToString(),
                 _amount);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
            {
                return this.ToString();
            }
            if(format == "d")
            {
                return String.Format("{0}", _timestamp.ToString());
            }
            if(format == "a")
            {
                return String.Format("{0}", _amount.ToString());
            }
            throw new FormatException(String.Format("Invalid format{0}", format));
        }
    }
}
