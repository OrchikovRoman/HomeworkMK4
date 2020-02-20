using BuisnessLogicLayer.Interfaces;
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

        public IEnumerable<CarViewModel> GetСars()
        {
            var detailControllers = from detail in detService.GetDetails()
                                    select new DetailViewModel() { Id = detail.Id, CarID = detail.CarID, Name = detail.Name };
            var carViewModels = from car in service.GetСars()
                                select new CarViewModel() { Id = car.Id, Name = car.Name, Details = detailControllers };
                                 
            return carViewModels;
        }
    }
}
