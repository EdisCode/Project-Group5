using Project_Group5.MVVM;
using Project_Group5.Services;
using Project_Group5.View;
using System.Windows;

namespace Project_Group5.ViewModel
{
    internal class LoginViewModel : AbstractViewModel
    {
        private string username = "";
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string password = "";
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public void OnSubmit(object sender, EventArgs e)
        {

            if (EmployeeService.Authenticate(username, password))
            {
                if (sender != null)
                {
                    ((Login)sender).txtPassword.Clear();
                    ((Login)sender).txtUsername.Clear();

                    App.NavitageTo(new DashboardViewModel());
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please, try again.", "Failed login", MessageBoxButton.OK, MessageBoxImage.Error);
            };
        }
    }
}
