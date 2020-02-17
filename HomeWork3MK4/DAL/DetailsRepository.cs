using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DetailsRepository : IDetailsRepository
    {
        public IEnumerable<Detail> GetDetails()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=AutoDB;Integrated Security=True";
            var query = "SELECT * FROM DetailsDB";
            var result = new List<Detail>();

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
                        result.Add(new Detail
                        {
                            Id = (int)reader["Id"],
                            Cars_Id = (int)reader["Id_Cars"],
                            NameDetail = (string)reader["NameDatails"]
                        });
                    }
                }
                connection.Close();

                return result;
            }
        }
    }
}
