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
    public class CarRepository : ICarRepository
    {
        string connectionString = @"Data Source=.; Initial Catalog=Automobile;Integrated Security=True";

        public void Create(Car car)
        {
            var sql = $"INSERT INTO Car (Name) OUTPUT INSERTED.Id VALUES ('{car.Name}');";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var insertedId = (int)connection.ExecuteScalar(sql);
                connection.Close();

                car.Id = insertedId;
            };
        }

        public void Delete(int Id)
        {
            var sql = $"DELETE FROM Car WHERE Id = {Id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            };
        }

        public Car GetById(int id)
        {
            var sql = $"SELECT * FROM Car h INNER JOIN Detail s on s.Id = h.CarID WHERE h.Id = {id};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var result = connection.Query<Car, Detail, Car>(sql, (car, detail) =>
                {
                    car.Details = (from res in car.Details
                                  select new Detail() { Id = res.Id, Name = res.Name, CarID = res.CarID }).ToList();

                    return car;
                });
                connection.Close();

                return result.FirstOrDefault();
            };
        }

        public IEnumerable<Car> GetCars()
        {

            var query = "SELECT * FROM Car s LEFT JOIN Detail d on s.Id=d.CarID WHERE s.Id=d.CarID";
           

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();
                var result = new List<Car>();

                var sqlResult = connection.Query<Car, Detail, Car>(query, (car, detail) =>
                {
                    var exCar = result.FirstOrDefault(x => x.Id == car.Id);
                    if (exCar==null)
                    {
                        result.Add(car);
                        exCar = car;
                    }
                    if(exCar.Details==null)
                    {
                        exCar.Details = new List<Detail>();
                    }
                    exCar.Details.Add(detail);
                    return exCar;
                });
                connection.Close();
                return result;
            };
        }

        public void Update(Car car)
        {
            var sql = $"UPDATE Car SET Name = '{car.Name}' WHERE Id = {car.Id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var result = connection.Execute(sql);
                connection.Close();
            };
        }
    }
}
