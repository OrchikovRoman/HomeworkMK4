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
    public class ManufacturerController : IManufacturerController
    {
        private readonly IManufacturerService service;

        public ManufacturerController()
        {
            service = new ManufacturerService();
        }
        public IEnumerable<ManufacturerViewModel> GetAll()
        {
            var model = service.GetAll();
            var manufacturerModel = model.Select(x => new ManufacturerViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CarsModel = x.CarsModel.Select(y => new CarViewModel
                {
                    Id = y.Id,
                    Name = y.Name,
                    Details = y.Details.Select(z => new DetailViewModel
                    {
                        Id = z.Id,
                        Name = z.Name,
                        CarID = z.CarID,
                        Price = z.Price
                    })
                }),
                DetailsModel = x.DetailsModel.Select(c => new DetailViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    CarID = c.CarID,
                    Price = c.Price
                })
            });

            return manufacturerModel;
        }

        public ManufacturerViewModel GetById(int Id)
        {
            var model = service.GetById(Id);

            var manufacturerModel = new ManufacturerViewModel
            {
                Id = model.Id,
                Name = model.Name,
                CarsModel = model.CarsModel.Select(x => new CarViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Details = x.Details.Select(y => new DetailViewModel
                    {
                        Id = y.Id,
                        Name = y.Name,
                        CarID = y.CarID,
                        Price = y.Price
                    })
                }),
                DetailsModel = model.DetailsModel.Select(z => new DetailViewModel
                {
                    Id = z.Id,
                    Name = z.Name,
                    CarID = z.CarID,
                    Price = z.Price
                })
            };

            return manufacturerModel;
        }
    }
}
