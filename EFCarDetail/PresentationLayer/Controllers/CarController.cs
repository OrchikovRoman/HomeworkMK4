using BuisnessLogicLayer.Interfaces;
using BuisnessLogicLayer.Models;
using BuisnessLogicLayer.Services;
using PresentationLayer.Interfaces;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class CarController : ICarController
    {
        private readonly ICarService service;

        public CarController()
        {
            service = new CarService();
        }

        public void Create(CarViewModel car)
        {
            var carCreate = new CarModel
            {
                Id = car.Id,
                Name = car.Name,
                Details = car.Details.Select(x => new DetailModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    CarID = x.CarID,
                    Price = x.Price
                })
            };
            service.Create(carCreate);
        }

        public void Delete(int Id)
        {
            service.Delete(Id);
        }

        public IEnumerable<CarViewModel> GetСars()
        {
            var carViewModels = service.GetСars().Select(x => new CarViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Details = x.Details.Select(y => new DetailViewModel
                {
                    Id = y.Id,
                    Name = y.Name,
                    CarID = y.CarID,
                    Price = y.Price
                })
            });
            return carViewModels;
        }

        public void Update(CarViewModel car)
        {
            var carUpdate = new CarModel
            {
                Id = car.Id,
                Name = car.Name,
                Details = car.Details.Select(x => new DetailModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    CarID = x.CarID,
                    Price = x.Price
                })
            };
            service.Update(carUpdate);
        }

        public CarViewModel GetById(int Id)
        {
            var model = service.GetById(Id);

            var carViewModel = new CarViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Details = model.Details.Select(x => new DetailViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    CarID = x.CarID,
                    Price = x.Price
                })
            };

            return carViewModel;
        }
    }
}
