/*****************************************************************************************
 * 
 * Academia Microsoft,
 * Curs: 2.NET
 * Laborator 2
 * 
 ****************************************************************************************/

using System;
using System.Collections.Generic;
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
    /// Interaction logic for NotesWindow.xaml
    /// </summary>
    public partial class NotesWindow : Window
    {
        // Account instance managed by the form.
        private Account _theAccount;

        public NotesWindow(Account acc)
        {
            InitializeComponent();

            // Set the Account object for this form.
            _theAccount = acc;

            // Set the caption on the form.
            this.Title = string.Format("Notes for account: {0}", _theAccount.Name);

            // TODO: Display the Notes keys in the combo box.
        }

        private void KeysComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Redisplay the notes.
            DisplayNotes();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected key in the combo box.
            string key = (string)KeysComboBox.SelectedValue;

            // Get the text entered by the user.
            string noteValue = NoteTextBox.Text;

            // TODO: Add value to key.

            // Redisplay the notes.
            DisplayNotes();
            NoteTextBox.Clear();
            NoteTextBox.Focus();
        }

        private void DisplayNotes()
        {
            // Get the selected key in the combo box.
            string key = (string)KeysComboBox.SelectedValue;

            // TODO: Get values for key.
            string[] noteValues = new string[] { };

            // Bind the list box to the note values.
            NotesListBox.ItemsSource = noteValues;
        }
    }
}
