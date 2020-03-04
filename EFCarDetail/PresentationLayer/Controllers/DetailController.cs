using BuisnessLogicLayer.Interfaces;
using BuisnessLogicLayer.Models;
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
    public class DetailController : IDetailController
    {
        private readonly IDetailService service;

        public DetailController()
        {
            service = new DetailService();
        }

        public void Create(DetailViewModel detail)
        {
            var detailCreate = new DetailModel()
            {
                Id = detail.Id,
                CarID = detail.CarID,
                Name = detail.Name,
                Price = detail.Price
            };
            service.Create(detailCreate);
        }

        public void Delete(int Id)
        {
            service.Delete(Id);
        }


        public IEnumerable<DetailViewModel> GetDetails()
        {
            var detailViewModels = service.GetDetails().Select(x => new DetailViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CarID = x.CarID,
                Price = x.Price
            });
            return detailViewModels;
        }

        public void Update(DetailViewModel detail)
        {
            var detailUpdate = new DetailModel()
            {
                Id = detail.Id,
                CarID = detail.CarID,
                Name = detail.Name,
                Price = detail.Price
            };
            service.Update(detailUpdate);
        }

        DetailViewModel IDetailController.GetById(int Id)
        {
            var model = service.GetById(Id);

            var detailViewModel = new DetailViewModel
            {
                Id = model.Id,
                Name = model.Name,
                CarID = model.CarID,
                Price = model.Price
            };
            return detailViewModel;
        }
    }
}
