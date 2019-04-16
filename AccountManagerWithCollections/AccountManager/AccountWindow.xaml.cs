/*****************************************************************************************
 * 
 * Academia Microsoft,
 * Curs: 2.NET
 * Laborator 2
 * 
 ****************************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AccountManager
{
    /// <summary>
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        // Account instance managed by the form.
        private Account _theAccount;

        public AccountWindow(Account acc)
        {
            InitializeComponent();

            // Set the Account object for this form.
            _theAccount = acc;

            // Set the caption on the form.
            this.Title = string.Format("Account: {0}", _theAccount.Name);
        }

        private void AccountWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _theAccount.LargeCredit += OnLargeCredit;
            _theAccount.LargeDebit += OnLargeDebit;
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            double amount = double.Parse(AmountTextBox.Text);
            _theAccount.Deposit(amount);
        }

        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            double amount = double.Parse(AmountTextBox.Text);

            try
            {
                _theAccount.Withdraw(amount);
            }
            catch (TransactionException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            // Display account details in a message box.
            string details = _theAccount.ToString();
            MessageBox.Show(details, "Account details");

            // Declare variables to hold transaction lists.
            List<Transaction<double>> all, deposits, withdrawals;

            if (SortByDateRadioButton.IsChecked.Value)
            {
                // Sort transactions by date.
                _theAccount.GetTransactionsByDate(out all, out deposits, out withdrawals);
            }
            else
            {
                // Sort transactions by amount.
                _theAccount.GetTransactionsByAmount(out all, out deposits, out withdrawals);
            }

            SortByDateRadioButton.IsChecked = false;
            SortByAmountRadioButton.IsChecked = false;

            // Display transactions.
            AllTransactionsListBox.ItemsSource = all;
            DepositsListBox.ItemsSource = deposits;
            WithdrawalsListBox.ItemsSource = withdrawals;
        }

        private void OnLargeCredit(object sender, TransactionEventArgs e)
        {
            string message = string.Format("Large credit at {0}: {1:c}\n", DateTime.Now, e.Amount);
            File.AppendAllText("LargeTransactions.txt", message);
        }

        private void OnLargeDebit(object sender, TransactionEventArgs e)
        {
            string message = string.Format("Large debit  at {0}: {1:c}\n", DateTime.Now, e.Amount);
            File.AppendAllText("LargeTransactions.txt", message);
        }

        private void NotesButton_Click(object sender, RoutedEventArgs e)
        {
            // Display the notes for the Account object in the NotesForm form.
            NotesWindow window = new NotesWindow(_theAccount);
            window.ShowDialog();
        }
    }
}
