using BuisnessLogicLayer.Interfaces;
using BuisnessLogicLayer.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Services
{
    public class CarService : ICarService
    {
        private IDetailRepository detRepository;
        private ICarRepository repository;

        public CarService()
        {
            repository = new CarRepository();
            detRepository = new DetailRepository();
        }

        public void Create(CarModel car)
        {
            var carModel = new Car()
            {
                Id = car.Id,
                Name = car.Name,
                Details = (from det in car.Details
                           select new Detail() { Id = det.Id, CarID = det.CarID, Name = det.Name }).ToList()
            };
            repository.Create(carModel);
        }

        public void Delete(CarModel car)
        {
            var carModel = new Car()
            {
                Id = car.Id,
                Name = car.Name,
                Details = (from det in car.Details
                           select new Detail() { Id = det.Id, CarID = det.CarID, Name = det.Name }).ToList()
            };
            repository.Delete(carModel);
        }

        public CarModel GetById(int Id)
        {
            var model = repository.GetById(Id);

            var carModel = new CarModel
            {
                Id = model.Id,
                Name = model.Name,
                Details = model.Details.Select(x => new DetailModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    CarID = x.CarID
                })
            };
            return carModel;
        }

        public IEnumerable<CarModel> GetСars()
        {
            var detailModels = from detail in detRepository.GetDetails()
                               select new DetailModel() { Id = detail.Id, CarID = detail.CarID, Name = detail.Name };
            var carModels = (from car in repository.GetCars()
                             select new CarModel() { Id = car.Id, Name = car.Name, Details = detailModels.Where(x => x.CarID == car.Id) }).ToList();
            return carModels;
        }

        public void Update(CarModel car)
        {
            var carModel = new Car()
            {
                Id = car.Id,
                Name = car.Name,
                Details = (from det in car.Details
                           select new Detail() { Id = det.Id, CarID = det.CarID, Name = det.Name }).ToList()
            };
            repository.Update(carModel);
        }
    }
}
