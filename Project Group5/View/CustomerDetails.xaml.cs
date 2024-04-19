using Project_Group5.ViewModel;
using System.Windows.Controls;

namespace Project_Group5.View
{
    /// <summary>
    /// Interaction logic for CustomerDetails.xaml
    /// </summary>
    public partial class CustomerDetails : UserControl
    {
        private CustomerDetailsViewModel customerDetailsViewModel;
        public CustomerDetails()
        {
            customerDetailsViewModel = new CustomerDetailsViewModel();
            DataContext = customerDetailsViewModel;

            InitializeComponent();
        }
    }
}
