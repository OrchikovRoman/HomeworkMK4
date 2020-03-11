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
        private readonly ICarRepository repository;

        public CarService()
        {
            repository = new CarRepository();
        }

        public void Create(CarModel car)
        {
            if (IsValid(car) == false)
                throw new Exception("Please change the name, this name is already taken!");
            else
            {
                var carModel = new Car()
                {
                    Id = car.Id,
                    Name = car.Name,
                    Details = car.Details.Select(x => new Detail
                    {
                        Id = x.Id,
                        Name = x.Name,
                        CarID = x.CarID,
                        Price = x.Price
                    }).ToList()
                };
                repository.Create(carModel);
            }

        }
        private bool IsValid(CarModel car)
        {
            if (repository.GetByName(car.Name) == null)
            {
                return true;
            }
            else
                return false;
        }


        public void Delete(int Id)
        {
            repository.Delete(Id);
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
                    CarID = x.CarID,
                    Price = x.Price
                })
            };
            return carModel;
        }

        public IEnumerable<CarModel> GetСars()
        {
            var model = repository.GetCars();
            var carModels = model.Select(x => new CarModel
            {
                Id = x.Id,
                Name = x.Name,
                Details = x.Details.Where(y => y.CarID == x.Id).Select(y => new DetailModel
                {
                    Id = y.Id,
                    Name = y.Name,
                    CarID = y.CarID,
                    Price = y.Price
                })
            });

            return carModels;
        }

        public void Update(CarModel car)
        {
            var carModel = new Car()
            {
                Id = car.Id,
                Name = car.Name,
                Details = car.Details.Select(x => new Detail
                {
                    Id = x.Id,
                    Name = x.Name,
                    CarID = x.CarID,
                    Price = x.Price
                }).ToList()
            };
            repository.Update(carModel);
        }
    }
}
