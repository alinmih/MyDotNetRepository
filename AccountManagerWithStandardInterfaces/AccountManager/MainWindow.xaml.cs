/*****************************************************************************************
 * 
 * Academia Microsoft,
 * Curs: 2.NET
 * Laborator 1
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AccountManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Account instance managed by the form.
        private Account _theAccount = new Account("John Doe");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, RoutedEventArgs e)
        {
            _theAccount.LargeCredit += OnLargeCredit;
            _theAccount.LargeDebit += OnLargeDebit;
        }

        private void Withdraw_Button_Click(object sender, RoutedEventArgs e)
        {

            double amount = double.Parse(amountTextBox.Text);
            try
            {
                _theAccount.Withdraw(amount);
            }
            catch (TransactionException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


            UpdateTransactionListBox();
        }

        private void Deposit_Button_Click(object sender, RoutedEventArgs e)
        {
            double amount = double.Parse(amountTextBox.Text);
            _theAccount.Deposit(amount);

            UpdateTransactionListBox();
        }

        private void Details_Button_Click(object sender, RoutedEventArgs e)
        {
            string details = String.Format("{0:d}", _theAccount);
            //String.Format("{d}", details);
            MessageBox.Show(details, "Account details");

            UpdateTransactionListBox();
        }

        private void UpdateTransactionListBox()
        {
            transactionsListBox.Items.Clear();
            Transaction<double>[] transactions = _theAccount.AllTransactions;

            foreach (Transaction<double> trans in transactions)
            {
                string str = string.Format("{0}", trans);

                transactionsListBox.Items.Add(str);
            }
        }

        private void OnLargeCredit(object sender, TransactionEventArgs e)
        {
            string message = string.Format("Large credit at {0}: {1:c}\n", DateTime.Now, e.Amount);

            File.AppendAllText("LargeTransactions.txt", message);
        }

        private void OnLargeDebit(object sender, TransactionEventArgs e)
        {
            string message = string.Format("Large debit at {0}:{1:c}\n", DateTime.Now, e.Amount);
            File.AppendAllText("LargeTransactions.txt", message);
        }
    }
}
