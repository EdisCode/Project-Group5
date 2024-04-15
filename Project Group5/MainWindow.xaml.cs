using System.Windows;

namespace Project_Group5
{
    public partial class MainWindow : Window
    {
        private const string ValidPassword = "1212";
        private readonly Dictionary<string, string> ValidUsernames = new()
        {
            { "Mahendra", ValidPassword },
            { "Edikan", ValidPassword },
            { "Anish", ValidPassword },
            { "Motunrayo", ValidPassword },
            { "Mayank", ValidPassword },
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            // Perform login logic
            if (ValidUsernames.TryGetValue(username, out string validPassword) && validPassword == password)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement cancel button logic here
            Close();
        }
    }
}