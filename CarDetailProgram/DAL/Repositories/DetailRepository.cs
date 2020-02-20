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
    public class DetailRepository : IDetailRepository
    {
        public IEnumerable<Detail> GetDetails()
        {
            string connectionString = @"Data Source=.; Initial Catalog=Automobile;Integrated Security=True";
            var query = "SELECT * FROM Detail";
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
                            CarID = (int)reader["CarID"],
                            Name = (string)reader["Name"]
                        });
                    }
                }
                connection.Close();

                return result;
            }
        }
    }
}
