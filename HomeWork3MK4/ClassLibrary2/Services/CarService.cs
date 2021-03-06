﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuisnessLogicLayer
{
    public class CarService : ICarService
    {

        private ICarRepository repository;

        public CarService()
        {
            repository = new CarRepository();
        }

        public IEnumerable<CarModel> GetСars()
        {
            var carsModels = from car in repository.GetCars()
                             select new CarModel() { Id = car.Id, NameCar = car.NameCar };
            return carsModels;
        }

    }
}
