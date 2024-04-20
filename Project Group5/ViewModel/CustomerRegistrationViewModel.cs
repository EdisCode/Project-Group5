using Project_Group5.Model;
using Project_Group5.MVVM;
using Project_Group5.Services;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Input;

namespace Project_Group5.ViewModel
{
    internal class CustomerRegistrationViewModel : AbstractViewModel
    {
        private string _name;
        private string _selectedGender;
        private string _selectedRoomBed;
        private string _selectedRoomType;
        private string _selectedRoomNumber;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string SelectedGender
        {
            get { return _selectedGender; }
            set
            {
                _selectedGender = value;
                OnPropertyChanged(nameof(SelectedGender));
            }
        }

        public string SelectedRoomBed
        {
            get { return _selectedRoomBed; }
            set
            {
                _selectedRoomBed = value;
                OnPropertyChanged(nameof(SelectedRoomBed));
            }
        }

        public string SelectedRoomType
        {
            get { return _selectedRoomType; }
            set
            {
                _selectedRoomType = value;
                OnPropertyChanged(nameof(SelectedRoomType));
            }
        }

        public string SelectedRoomNumber
        {
            get { return _selectedRoomNumber; }
            set
            {
                _selectedRoomNumber = value;
                OnPropertyChanged(nameof(SelectedRoomNumber));
            }
        }

        public ObservableCollection<string> Genders { get; set; }
        public ObservableCollection<string> RoomTypes { get; set; }
        public ObservableCollection<string> RoomBeds { get; set; }
        public ObservableCollection<string> RoomNumbers { get; set; }

        public ICommand SubmitCommand { get; private set; }

        public CustomerRegistrationViewModel()
        {
            Genders = new ObservableCollection<string>();
            RoomTypes = new ObservableCollection<string>();
            RoomBeds = new ObservableCollection<string>();
            RoomNumbers = new ObservableCollection<string>();

            LoadRoomDetails();
            LoadGender();

            // Initialize properties and commands
            SubmitCommand = new RelayCommand(OnSubmit);
        }

        private void LoadRoomDetails()
        {
            // Fetch room details from the database using RoomService
            DataTable roomData = RoomService.GetAll();

            // Populate combo box items with fetched data
            foreach (DataRow row in roomData.Rows)
            {
                RoomTypes.Add(row["Type"].ToString());
                RoomBeds.Add(row["Bed"].ToString());
                RoomNumbers.Add(row["RoomNumber"].ToString());
            }
        }

        private void LoadGender()
        {
            // Hardcode genders
            Genders.Add("Male");
            Genders.Add("Female");
            Genders.Add("Other");
        }

        private void OnSubmit(object parameter)
        {
            try
            {
                // Create a new customer model with inputted data
                CustomerModel customer = new CustomerModel
                {
                    Name = Name,
                    Gender = SelectedGender,
                    // Set other properties
                };

                // Insert the customer into the database
                bool success = CustomerService.AddCustomer(customer);

                if (success)
                {
                    // Clear input fields or show success message
                    // Reset the form
                }
                else
                {
                    // Show error message
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
        }
    }
}
