using Project_Group5.ViewModel;
using System.Windows.Controls;

namespace Project_Group5.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private LoginViewModel loginViewModel;

        public Login()
        {
            loginViewModel = new LoginViewModel();
            DataContext = loginViewModel;

            InitializeComponent();
        }

        public void OnSubmit(object sender, EventArgs e)
        {
            loginViewModel.OnSubmit(this, e);
        }
    }
}
