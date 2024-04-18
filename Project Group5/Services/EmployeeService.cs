using Project_Group5.Models;
using System.Collections.ObjectModel;

namespace Project_Group5.Services
{
    public class EmployeeService
    {
        public static bool Authenticate(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return false;
            } 
            else
            {
                return true;
            }
        }

        public static ObservableCollection<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public static Employee? GetByID(Employee employee)
        {
            throw new NotImplementedException();
        }

        public static Employee? Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public static Employee? Delete(string employeeID)
        {
            throw new NotImplementedException();
        }
    }
}
