using Microsoft.Data.SqlClient;
using Project_Group5.Database;
using Project_Group5.Model;
using System.Collections.ObjectModel;
using System.Data;

namespace Project_Group5.Services
{
    public class CustomerService : DatabaseConnection
    {
        private ObservableCollection<CustomerModel> customerList;

        public CustomerService()
        {
            customerList = new ObservableCollection<CustomerModel>();
        }

        public static CustomerModel? GetByID(string customerID)
        {
            throw new NotImplementedException();
        }
        public static ObservableCollection<CustomerModel>? GetAll()
        {
            throw new NotImplementedException();
        }

        public static CustomerModel? SearchByID(string customerID)
        {
            throw new NotImplementedException();
        }

        public static CustomerModel? SearchByCategory(CustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public static CustomerModel? Add(CustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public static CustomerModel? Delete(string customerID)
        {
            throw new NotImplementedException();
        }

        public static CustomerModel? Edit(CustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public static DataTable GetAllCustomers()
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Customers]";
                using (var adapter = new SqlDataAdapter(command))
                {
                    DataTable customers = new DataTable();
                    adapter.Fill(customers);
                    return customers;
                }
            }
        }

        public static bool AddCustomer(CustomerModel customer)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Customers (Name, Gender, ...) 
                                       VALUES (@Name, @Gender, ...)";

                // Add parameters for customer properties
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = customer.Name;
                command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = customer.Gender;
                // Add other parameters

                // Execute the command and return true if successful
                return command.ExecuteNonQuery() > 0;
            }
        }

        
    }
}
