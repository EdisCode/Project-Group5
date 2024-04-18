using Project_Group5.Models;
using System.Collections.ObjectModel;

namespace Project_Group5.Services
{
    public class CustomerService
    {
        private ObservableCollection<Customer> customerList;

        public CustomerService()
        {
            customerList = new ObservableCollection<Customer>();
        }

        public static Customer? GetByID(string customerID)
        {
            throw new NotImplementedException();
        }
        public static ObservableCollection<Customer>? GetAll()
        {
            throw new NotImplementedException();
        }

        public static Customer? SearchByID(string customerID)
        {
            throw new NotImplementedException();
        }

        public static Customer? SearchByCategory(Customer customer)
        {
            throw new NotImplementedException();
        }

        public static Customer? Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public static Customer? Delete(string customerID)
        {
            throw new NotImplementedException();
        }

        public static Customer? Edit(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
