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
    public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository repository;
        public ManufacturerService()
        {
            repository = new ManufacturerRepository();
        }
        public IEnumerable<ManufacturerModel> GetAll()
        {
            var model = repository.GetAll();
            var manufacturer = model.Select(x => new ManufacturerModel
            {
                Id = x.Id,
                Name = x.Name,
                CarsModel = x.Cars.Select(y => new CarModel
                {
                    Id = y.Id,
                    Name = y.Name,
                    Details = y.Details.Select(z => new DetailModel
                    {
                        Id = z.Id,
                        Name = z.Name,
                        CarID = z.CarID,
                        Price = z.Price
                    })
                }),
                DetailsModel = x.Details.Select(c => new DetailModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    CarID = c.CarID,
                    Price = c.Price
                })
            });

            return manufacturer;
        }

        public ManufacturerModel GetById(int Id)
        {
            var model = repository.GetById(Id);

            var manufacturerModel = new ManufacturerModel
            {
                Id = model.Id,
                Name = model.Name,
                CarsModel = model.Cars.Select(x => new CarModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Details = x.Details.Select(y => new DetailModel
                    {
                        Id = y.Id,
                        Name = y.Name,
                        CarID = y.CarID,
                        Price = y.Price
                    })
                }),
                DetailsModel = model.Details.Select(z => new DetailModel
                {
                    Id = z.Id,
                    Name = z.Name,
                    CarID = z.CarID,
                    Price = z.Price
                })
            };

            return manufacturerModel;
        }

        public CarManufacturerModel GetMostExpensive()
        {
            var AllManuf = repository.GetAll();
            var manufacturer = AllManuf.OrderBy(x => x.Cars.Max(y => y.Details.Sum(z => z.Price))).FirstOrDefault();
            var manufCars = manufacturer.Cars.Select(x => new CarModel
            {
                Id = x.Id,
                Name = x.Name,
                Details = x.Details.Select(y => new DetailModel
                {
                    Id = y.Id,
                    Name = y.Name,
                    Price = y.Price,
                }),
            });
            var expensiveCar = manufCars.OrderByDescending(x => x.Details.Sum(y => y.Price)).FirstOrDefault();

            var carManufacturerModel = new CarManufacturerModel
            {
                CarsModel = new CarModel
                {
                    Id = expensiveCar.Id,
                    Name = expensiveCar.Name,
                    Details = expensiveCar.Details.Select(x => new DetailModel
                    {
                        Name = x.Name,
                        Price = x.Price,
                        CarID = x.CarID,
                        Id = x.Id
                    })
                },
                ManufacturerModel = new ManufacturerModel
                {
                    Id = manufacturer.Id,
                    Name = manufacturer.Name,
                    CarsModel = manufacturer.Cars.Select(y => new CarModel
                    {
                        Id = y.Id,
                        Name = y.Name,
                        Details = y.Details.Select(z => new DetailModel
                        {
                            Id = z.Id,
                            Name = z.Name,
                            CarID = z.CarID,
                            Price = z.Price
                        })
                    }),
                    DetailsModel = manufacturer.Details.Select(c => new DetailModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                        CarID = c.CarID,
                        Price = c.Price
                    })
                }
            };
            return carManufacturerModel;
        }
    }
}
