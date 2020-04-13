using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Exercise1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidName(NameTextBox.Text))
            {
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            }
            if (!ValidPhone(PhoneTextBox.Text))
            {
                MessageBox.Show("Phone number is invalid");
            }
            if (!ValidEmail(EmailTextBox.Text))
            {
                MessageBox.Show("Email is invalid");
            }


        }

        private bool ValidName(string name)
        {
            if (!Regex.IsMatch(name, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                return false;
            }
            return true;
        }

        private bool ValidPhone(string name)
        {
            if (!Regex.IsMatch(name, @"^(\+?36)?[ -]?(\d{1,2}|(\(\d{1,2}\)))/?([ -]?\d){6,7}$"))
            {
                return false;
            }
            return true;
        }

        private bool ValidEmail(string name)
        {
            if (!Regex.IsMatch(name, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                return false;
            }
            return true;
        }
    }
}
