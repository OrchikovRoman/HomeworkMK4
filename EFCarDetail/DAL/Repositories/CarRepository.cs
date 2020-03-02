using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDetailsContext _ctx;
        public CarRepository()
        {
            _ctx = new CarDetailsContext();
        }

        public void Create(Car car)
        {
            _ctx.Car.Add(car);
            _ctx.SaveChanges();
        }

        public void Delete(int Id)
        {
            _ctx.Car.Remove(_ctx.Car.FirstOrDefault(x => x.Id == Id));
            _ctx.SaveChanges();
        }

        public Car GetById(int id)
        {
            return _ctx.Car.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Car> GetCars()
        {
            return _ctx.Car.AsNoTracking().ToList();
        }

        public void Update(Car car)
        {
            var updateCar = _ctx.Car.Select(x => new Car
            {
                Id = car.Id,
                Name = car.Name,
                Details = car.Details.Select(y => new Detail
                {
                    Id = y.Id,
                    Name = y.Name,
                    CarID = y.CarID
                }).ToList()
            }).FirstOrDefault();
            _ctx.SaveChanges();
        }
    }
}
