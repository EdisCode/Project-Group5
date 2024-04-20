using Project_Group5.MVVM;
using Project_Group5.Model;
using Project_Group5.Services;
using System;
using System.Collections.ObjectModel;
using System.Data;

namespace Project_Group5.ViewModel
{
    internal class CustomerDetailsViewModel : AbstractViewModel
    {
        public ObservableCollection<CustomerModel> CustomerList { get; set; }

        public CustomerDetailsViewModel()
        {
            CustomerList = new ObservableCollection<CustomerModel>();
            LoadCustomers(); // Load existing customers from the database
        }

        private void LoadCustomers()
        {
            
                DataTable dataTable = CustomerService.GetAllCustomers();
                foreach (DataRow row in dataTable.Rows)
                {
                CustomerModel customer = new CustomerModel()
                {
                    CustomerID = Convert.ToInt32(row["CustomerID"]),
                    Name = row["Name"].ToString(),
                    Gender = row["Gender"].ToString(),
                    Telephone = row["Telephone"].ToString(),
                    Address = row["Address"].ToString(),
                    Nationality = row["Nationality"].ToString(),
                    IDProof = row["IDProof"].ToString(),


                };

                    // Handle DBNull for DateOfBirth, CheckInDate, and CheckOutDate
                    if (row["DateOfBirth"] != DBNull.Value)
                    {
                        customer.DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
                    }
                    if (row["CheckInDate"] != DBNull.Value)
                    {
                        customer.CheckInDate = Convert.ToDateTime(row["CheckInDate"]);
                    }
                    if (row["CheckOutDate"] != DBNull.Value)
                    {
                        customer.CheckOutDate = Convert.ToDateTime(row["CheckOutDate"]);
                    }

                    CustomerList.Add(customer);
                }
        }
    }
}
