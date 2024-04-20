using Project_Group5.ViewModel;
using System.Windows;
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
            Loaded += CustomerRegistration_Loaded;

        }

        private void CustomerRegistration_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            // Populate combo boxes when the control is loaded
            txtBed.ItemsSource = customerRegistrationViewModel.RoomBeds;
            txtRoomType.ItemsSource = customerRegistrationViewModel.RoomTypes;
            txtRoomNumber.ItemsSource = customerRegistrationViewModel.RoomNumbers;
        }

        public void OnSubmit(object sender, EventArgs e)
        {
            customerRegistrationViewModel.SubmitCommand.Execute(null);
        }

        private void txtBed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Update selected bed in view model
            var comboBox = sender as ComboBox;
            customerRegistrationViewModel.SelectedRoomBed = comboBox.SelectedItem as string;
        }

        private void txtRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Update selected room type in view model
            var comboBox = sender as ComboBox;
            customerRegistrationViewModel.SelectedRoomType = comboBox.SelectedItem as string;
        }

        private void txtRoomNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Update selected room number in view model
            var comboBox = sender as ComboBox;
            customerRegistrationViewModel.SelectedRoomNumber = comboBox.SelectedItem as string;
        }

        private void txtGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string selectedGender = comboBox.SelectedItem as string;

            // You can use the selected gender here as needed
        }

        private void OnSubmit(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("Room Allocated");
            customerRegistrationViewModel.SubmitCommand.Execute(null);
        }
    }
}

