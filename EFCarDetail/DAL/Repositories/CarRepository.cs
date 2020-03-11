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

        public Car GetByName(string Name)
        {
            return _ctx.Car.FirstOrDefault(x => x.Name == Name);
        }

        public IEnumerable<Car> GetCars()
        {
            return _ctx.Car.AsNoTracking().ToList();
        }

        public void Update(Car car)
        {
            var updateCar = _ctx.Car.FirstOrDefault(x => x.Id == car.Id);
            updateCar.Id = car.Id;
            updateCar.Name = car.Name;
            updateCar.Details = car.Details; 
            _ctx.SaveChanges();
        }
    }
}
