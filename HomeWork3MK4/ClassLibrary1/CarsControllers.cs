using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuisnessLogicLayer;


namespace PresentatinLayer
{
    public class CarsControllers : ICarsControllers
    {
        ICarsServices services = new CarsServices();

        public IEnumerable<CarViewModel> GetСarsModelsView()
        {
            var carsViewModels = from car in services.GetСarsModels()
                                 select new CarViewModel() { Id = car.Id, NameCar = car.NameCar };
            return carsViewModels;
        }
    }
}
