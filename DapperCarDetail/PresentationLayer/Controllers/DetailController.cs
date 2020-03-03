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
        private IDetailService service;

        public DetailController()
        {
            service = new DetailService();
        }

        public void Create(DetailViewModel detail)
        {
            var detailCreate = new DetailModel() 
            {
                Id=detail.Id,
                CarID=detail.CarID,
                Name=detail.Name
            };
            service.Create(detailCreate);
        }

        public void Delete(int Id)
        {
            service.Delete(Id);
        }


        public IEnumerable<DetailViewModel> GetDetails()
        {
            var detailViewModels = from det in service.GetDetails()
                                   select new DetailViewModel() { Id = det.Id, CarID = det.CarID, Name = det.Name };
            return detailViewModels;
        }

        public void Update(DetailViewModel detail)
        {
            var detailUpdate = new DetailModel()
            {
                Id = detail.Id,
                CarID = detail.CarID,
                Name = detail.Name
            };
            service.Update(detailUpdate);
        }

        public DetailViewModel GetById(int Id)
        {
            var model = service.GetById(Id);

            var detailViewModel = new DetailViewModel
            {
                Id = model.Id,
                Name = model.Name,
                CarID = model.CarID
            };
            return detailViewModel;
        }
    }
}
