using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuisnessLogicLayer;


namespace PresentatinLayer
{
    public class CarController : ICarController
    {
        private ICarService service;

        public CarController()
        {
            service = new CarService();
        }

        public IEnumerable<CarViewModel> GetСars()
        {
            var carsViewModels = from car in service.GetСars()
                                 select new CarViewModel() { Id = car.Id, NameCar = car.NameCar };
            return carsViewModels;
        }
    }
}
