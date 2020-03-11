using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.D.Problem
{
    //Presentation layer
    public class CarController
    {
        CarService carService = new CarService();
        public void Create(CarViewModel carViewModel)
        {
            //type casting: CarModel
            //carService.Create(carViewModel);
        }
    }

    //Buisness Logic Layer
    public class CarService
    {
        CarRepository carRepository = new CarRepository();
        public void Create(CarModel carModel)
        {
            //type casting: Car
            //carRepository.Create(carModel);
        }
    }

    //DAL
    public class CarRepository
    {
        public void Create(Car car)
        {
            //ctx.Car.Add(car);
            //ctx.SaveChanges();
        }
    }

    //models
    public class CarViewModel { }
    public class CarModel { }
    public class Car { }
}
