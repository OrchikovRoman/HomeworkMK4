using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogicLayer
{
    public class CarsServices : ICarsServices
    {

        ICarsRepository repository = new CarsRepository();

        public IEnumerable<CarModel> GetСarsModels()
        {
            var carsModels = from car in repository.GetCars()
                             select new CarModel() { Id = car.Id, NameCar = car.NameCar };
            return carsModels;
        }

    }
}
