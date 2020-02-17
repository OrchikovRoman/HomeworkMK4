using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class CarsRepository : ICarsRepository
    {
        public IEnumerable<Car> GetCars()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=AutoDB;Integrated Security=True";
            var query = "SELECT * FROM Cars";
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
                            NameCar = (string)reader["NameCar"]
                        });
                    }
                }
                connection.Close();

                return result;
            }
        }
    }
}
