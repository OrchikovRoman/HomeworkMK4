using BuisnessLogicLayer.Interfaces;
using BuisnessLogicLayer.Models;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Services
{
    public class CarService : ICarService
    {
        private IDetailRepository detRepository;
        private ICarRepository repository;

        public CarService()
        {
            repository = new CarRepository();
            detRepository = new DetailRepository();
        }

        public IEnumerable<CarModel> GetСars()
        {
            var detailModels = from detail in detRepository.GetDetails()
                               select new DetailModel() { Id = detail.Id, CarID = detail.CarID, Name = detail.Name };
            var carModels = from car in repository.GetCars()
                            select new CarModel() { Id = car.Id, Name = car.Name, Details = detailModels.Where(x=>x.CarID==car.Id)};
            return carModels;
        }
    }
}
