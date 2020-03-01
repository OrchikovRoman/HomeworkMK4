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
        private ICarService service;
        private IDetailService detService;

        public CarController()
        {
            service = new CarService();
            detService = new DetailService();
        }

        public void Create(CarViewModel car)
        {
            var carCreate = new CarModel()
            {
                Id = car.Id,
                Name = car.Name,
                Details = from res in car.Details
                          select new DetailModel() { Id = res.Id, Name = res.Name, CarID = res.CarID }
            };
            service.Create(carCreate);
        }

        public void Delete(int Id)
        {
            service.Delete(Id);
        }

        public IEnumerable<CarViewModel> GetСars()
        {
            var carViewModels = from car in service.GetСars()
                                select new CarViewModel()
                                {
                                    Id = car.Id,
                                    Name = car.Name,
                                    Details = from res in car.Details
                                              select new DetailViewModel() { Id = res.Id, Name = res.Name, CarID = res.CarID }
                                };


            return carViewModels;
        }

        public void Update(CarViewModel car)
        {
            var carUpdate = new CarModel()
            {
                Id = car.Id,
                Name = car.Name,
                Details = from res in car.Details
                          select new DetailModel() { Id = res.Id, Name = res.Name, CarID = res.CarID }
            };
            service.Update(carUpdate);
        }

        CarViewModel ICarController.GetById(int Id)
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
                    CarID = x.CarID
                })
            };

            return carViewModel;
        }
    }
}
