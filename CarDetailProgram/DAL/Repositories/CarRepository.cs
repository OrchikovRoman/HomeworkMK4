using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetCars()
        {
            string connectionString = @"Data Source=.; Initial Catalog=Automobile;Integrated Security=True";
            var query = "SELECT * FROM Car";
            var result = new List<Car>();

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Car
                        {
                            Id = (int)reader["Id"],
                            NameCar = (string)reader["Name"]
                        });
                    }
                }
                connection.Close();

                return result;
            }
        }
    }
}
