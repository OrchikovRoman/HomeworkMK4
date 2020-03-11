using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSOLID.D.Decision
{

    //Presentation layer
    public class CarController : ICarController
    {
        private readonly ICarService service;
        public CarController()
        {
            service = new CarService();
        }
        public void Create(CarViewModel carViewModel)
        {
            //type casting: CarModel
            //service.Create(carViewModel);
        }
    }

    //Buisness Logic Layer
    public class CarService : ICarService
    {
        private readonly ICarRepository repository;
        public CarService()
        {
            repository = new CarRepository();
        }
        public void Create(CarModel carModel)
        {
            //type casting: Car
            //repository.Create(carModel);
        }
    }

    //DAL
    public class CarRepository : ICarRepository
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

    //interfaces
    public interface ICarController
    {
        void Create(CarViewModel carViewModel);
    }
    public interface ICarService
    {
        void Create(CarModel carModel);
    }
    public interface ICarRepository 
    {
        void Create(Car car);
    }
}
