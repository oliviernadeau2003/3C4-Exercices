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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cours04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class FormsWindow_ON : Window
    {
        public FormsWindow_ON()
        {
            InitializeComponent();
        }

        public void Submit(object sender, RoutedEventArgs e)       // Valid info
        {
            string prefix = "";
            string errorMsg = "";

            List<User> userList = new List<User>();
            int UserNumber = userList.Count();


            if (xMrPrefix.IsChecked == false && xMrsPrefix.IsChecked == false)
            {
                errorMsg = errorMsg + "\nEnter a Prefix";
                xPrefixText.Foreground = Brushes.Red;
            }
            if (xFirstName.Text == "")
            {
                errorMsg = errorMsg + "\nEnter a First Name";
                xFirstNameText.Foreground = Brushes.Red;
            }
            if (xLastName.Text == "")
            {
                errorMsg = errorMsg + "\nEnter a Last Name";
                xLastNameText.Foreground = Brushes.Red;
            }
            if (xPostalCode.Text == "")
            {
                errorMsg = errorMsg + "\nEnter a Postal Code";
                xPostalCodeText.Foreground = Brushes.Red;
            }
            if (xUserName.Text == "")
            {
                errorMsg = errorMsg + "\nEnter a Username";
                xUserNameText.Foreground = Brushes.Red;
            }
            if (xPassword.Password == "")
            {
                errorMsg = errorMsg + "\nEnter a Password";
                xPasswordText.Foreground = Brushes.Red;
            }
            if (xConfimPassword.Password == "")
            {
                errorMsg = errorMsg + "\nConfirm your Password";
                xConfimPasswordText.Foreground = Brushes.Red;
            }
            if (xTerms.IsChecked == false)
            {
                errorMsg = errorMsg + "\nYou must agree to terms of service";
                xTermsText.Foreground = Brushes.Red;
            }

            if (errorMsg != "")
                MessageBox.Show(errorMsg,"Error",MessageBoxButton.OK,MessageBoxImage.Error);

            if (xMrPrefix.IsChecked == true)
                prefix = "Mr";
            else
                prefix = "Mrs";

            if (errorMsg == "")
            {
                User user = new User()
                {
                    Prefix = prefix,
                    FirstName = xFirstName.Text,
                    LastName = xLastName.Text,
                    PostalCode = xPostalCode.Text,
                    Username = xUserName.Text,
                    Password = xPassword.Password,
                    NewsletterSubscribtion = false,
                    Addresse = xAddress.Text,
                    Province = xProvince.Text,
                    DateOfBirth = xDateOfBirth.Text
                };
                userList.Add(user);
            }

        }

        private void Clear(object sender, RoutedEventArgs e)
        {

            xPrefixText.Foreground = Brushes.Black;
            xMrPrefix.IsChecked = false;
            xMrsPrefix.IsChecked = false;

            xFirstNameText.Foreground = Brushes.Black;
            xFirstName.Clear();

            xLastNameText.Foreground = Brushes.Black;
            xLastName.Clear();

            xAddress.Clear();

            xPostalCodeText.Foreground = Brushes.Black;
            xPostalCode.Clear();

            xProvince.Text = "";

            xDateOfBirth.Text = "";

            xUserNameText.Foreground = Brushes.Black;
            xUserName.Clear();

            xPasswordText.Foreground = Brushes.Black;
            xPassword.Clear();

            xConfimPasswordText.Foreground = Brushes.Black;
            xConfimPassword.Clear();

            xTermsText.Foreground = Brushes.Black;

            xTerms.IsChecked = false;

        }
    }

    public class User 
    { 
        public string Prefix;
        public string FirstName;
        public string LastName;
        public string Addresse;
        public string PostalCode;
        public string Province;
        public string DateOfBirth;
        public string Username;
        public string Password;

        public string ConfirmPassword;
        public bool AgreeTerms = false;
        public bool NewsletterSubscribtion  = false;

    }
}
