/*****************************************************************************************
 * 
 * Academia Microsoft,
 * Curs: 2.NET
 * Laborator 2
 * 
 ****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        // DataGrid collection that will be binded to the UI
        ObservableCollection<AccountModel> dataGridCollection;

        // TODO: Define a Dictionary of accounts.
        Dictionary<int, Account> _accounts = new Dictionary<int, Account>();

        // Integer that provides the next account number.
        private int _nextAccountNumber = 0;

        public MainWindow()
        {
            InitializeComponent();

            dataGridCollection = new ObservableCollection<AccountModel>();
        }

        private void AddAccountButton_Click(object sender, RoutedEventArgs e)
        {
            // Create an Account object with the specified name.
            Account acc = new Account(NameTextBox.Text);

            // TODO: Add the Account object to the dictionary.
            _accounts.Add(_nextAccountNumber, acc);
            // Increment the account number, ready for the next account.
            _nextAccountNumber++;

            // Redisplay all accounts.
            DisplayAccounts();
            NameTextBox.Clear();
            NameTextBox.Focus();
        }

        private void DisplayAccounts()
        {
            // Clear the DataGrid.
            dataGridCollection.Clear();

            // TODO: Display dictionary entries in AccountsDataGrid.
            foreach (KeyValuePair<int,Account> item in _accounts)
            {
                AccountModel acc = new AccountModel();
                acc.Account = item.Value;
                acc.Number = item.Key;
                dataGridCollection.Add(acc);
            }

            AccountsDataGrid.ItemsSource = dataGridCollection;
        }

        private void AccountsDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Get the account number of the selected row in the DataGridView.
            int accNum = (AccountsDataGrid.SelectedItem as AccountModel).Number;
            
            // TODO: Lookup the Account object in the dictionary.
            Account theAccount = null;
            theAccount = _accounts[accNum];

            // Display the Account object in the AccountForm form.
            AccountWindow window = new AccountWindow(theAccount);
            window.ShowDialog();

            // Redisplay all accounts.
            DisplayAccounts();
        }

        private class AccountModel
        {
            public int Number { get; set; }
            public Account Account { get; set; }
        }
    }
}
