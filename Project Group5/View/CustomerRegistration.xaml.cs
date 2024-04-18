using Project_Group5.ViewModel;
using System.Windows.Controls;

namespace Project_Group5.View
{
    /// <summary>
    /// Interaction logic for CustomerRegistration.xaml
    /// </summary>
    public partial class CustomerRegistration : UserControl
    {
        private CustomerRegistrationViewModel customerRegistrationViewModel;

        public CustomerRegistration()
        {
            customerRegistrationViewModel = new CustomerRegistrationViewModel();
            DataContext = customerRegistrationViewModel;

            InitializeComponent();
        }

        public void OnSubmit(object sender, EventArgs e)
        {
        }
    }
}
