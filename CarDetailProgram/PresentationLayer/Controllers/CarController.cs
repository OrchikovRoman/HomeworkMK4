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
    }
}
