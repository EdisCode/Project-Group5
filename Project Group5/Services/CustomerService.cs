using Project_Group5.Database;
using Project_Group5.Model;
using System.Collections.ObjectModel;

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
    }
}
