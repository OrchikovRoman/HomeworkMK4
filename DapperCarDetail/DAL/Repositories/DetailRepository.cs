using DAL.Interfaces;
using DAL.Models;
using Dapper;
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
        string connectionString = @"Data Source=.; Initial Catalog=Automobile;Integrated Security=True";

        public void Create(Detail detail)
        {
            var sql = $"INSERT INTO Detail (CarID, Name) OUTPUT INSERTED.Id VALUES ({detail.CarID}, '{detail.Name}');";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var insertedId = (int)connection.ExecuteScalar(sql);
                connection.Close();

                detail.Id = insertedId;
            };
        }

        public void Delete(Detail detail)
        {
            var sql = $"DELETE FROM Detail WHERE Id = {detail.Id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            };
        }

        public Detail GetById(int id)
        {
            var sql = $"SELECT * FROM Detail WHERE Id = {id};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var result = connection.Query<Detail>(sql).FirstOrDefault();
                connection.Close();

                return result;
            };


        }

        public IEnumerable<Detail> GetDetails()
        {
            var query = "SELECT * FROM Detail";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                var result = connection.Query<Detail>(query).FirstOrDefault();
                connection.Close();
                yield return result;
            }
        }

        public void Update(Detail detail)
        {
            var sql = $"UPDATE Detail SET Name = '{detail.Name}', '{detail.CarID}' WHERE Id = {detail.Id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            };
        }
    }
}
