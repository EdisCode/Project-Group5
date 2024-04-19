using Microsoft.Data.SqlClient;
using Project_Group5.Database;
using Project_Group5.Model;
using System.Data;

namespace Project_Group5.Services
{
    public class EmployeeService : DatabaseConnection
    {
        public static bool Authenticate(string username, string password)
        {
            bool isValidData = false;

            if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
            {
                using (var connection = GetConnection())
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM [Employees] WHERE [Username]=@Username AND [Password]=@Password";
                    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                    isValidData = command.ExecuteScalar() == null ? false : true;
                }
            }

            return isValidData;
        }

        public static IEnumerable<EmployeeModel>? GetAll()
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Employees]";
                var employees = command.ExecuteScalar();

                return (IEnumerable<EmployeeModel>?)employees;
            }
        } 

        public static EmployeeModel? GetByID(int employeeID)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Employees] WHERE [EmployeeID]=@EmployeeID";
                command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeID;

                var employee = command.ExecuteScalar() as EmployeeModel;

                if (employee != null)
                {
                    return new EmployeeModel()
                    {
                        EmployeeID = employee.EmployeeID,
                        Name = employee.Name,
                        Gender = employee.Gender,
                        Telephone = employee.Telephone,
                        Email = employee.Email,
                        Username = employee.Username,
                        Password = "",
                    };
                }

                return null;
            }

        }

        public static EmployeeModel? Add(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public static EmployeeModel? Delete(string employeeID)
        {
            throw new NotImplementedException();
        }
    }
}
