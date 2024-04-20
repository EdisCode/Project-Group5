using Microsoft.Data.SqlClient;
using Project_Group5.Database;
using Project_Group5.Model;
using System.Data;

namespace Project_Group5.Services
{
    public class RoomService : DatabaseConnection
    {
        public static DataTable GetAll()
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Rooms]";
                using (var adapter = new SqlDataAdapter(command))
                {
                    DataTable rooms = new DataTable();
                    adapter.Fill(rooms);

                    return rooms;
                }
            }
        }

        public static RoomModel? GetByID(string roomNumber)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [Rooms] WHERE [RoomNumber]=@RoomNumber";
                command.Parameters.Add("@RoomNumber", SqlDbType.VarChar).Value = roomNumber;

                var room = command.ExecuteScalar() as RoomModel;

                if (room != null)
                {
                    return new RoomModel()
                    {
                        RoomID = room.RoomID,
                        RoomNumber = room.RoomNumber,
                        Type = room.Type,
                        Bed = room.Bed,
                        Price = room.Price,
                        Booked = Convert.ToBoolean(room.Booked),
                    };
                }

                return null;
            }
        }

        public static bool Add(RoomModel room)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO [Rooms] ([RoomNumber], [Type], [Bed], [Price])
                                        VALUES (@RoomNumber, @Type, @Bed, @Price)";
                command.Parameters.Add("@RoomNumber", SqlDbType.VarChar).Value = room.RoomNumber;
                command.Parameters.Add("@Type", SqlDbType.VarChar).Value = room.Type;
                command.Parameters.Add("@Bed", SqlDbType.VarChar).Value = room.Bed;
                command.Parameters.Add("@Price", SqlDbType.Float).Value = room.Price;

                 return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
