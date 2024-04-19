using Microsoft.Data.SqlClient;

namespace Project_Group5.Database
{
    public class DatabaseConnection
    {
        private static readonly string connectionString = @"Server=EDIKANS-SPECTRE\EDIKANSQL; Initial Catalog=MyHotel; Trusted_Connection=True; TrustServerCertificate=True";

        protected static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
