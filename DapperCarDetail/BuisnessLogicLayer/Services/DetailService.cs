using BuisnessLogicLayer.Interfaces;
using BuisnessLogicLayer.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Services
{
    public class DetailService : IDetailService
    {
        private IDetailRepository repository;

        public DetailService()
        {
            repository = new DetailRepository();
        }

        public void Create(DetailModel detail)
        {
            var detailCreate = new Detail()
            {
                Id=detail.Id,
                CarID=detail.CarID,
                Name=detail.Name
            };
            repository.Create(detailCreate);
        }

        public void Delete(DetailModel detail)
        {
            var detailDelete = new Detail()
            {
                Id = detail.Id,
                CarID = detail.CarID,
                Name = detail.Name
            };
            repository.Delete(detailDelete);
        }

        public DetailModel GetById(int Id)
        {
            var model = repository.GetById(Id);

            var detailModel = new DetailModel
            {
                Id = model.Id,
                Name = model.Name,
                CarID = model.CarID
            };
            return detailModel;
        }

        public IEnumerable<DetailModel> GetDetails()
        {
            var detailModels = from det in repository.GetDetails()
                               select new DetailModel() { Id = det.Id, CarID = det.CarID, Name = det.Name };
            return detailModels;
        }

        public void Update(DetailModel detail)
        {
            var detailUpdate = new Detail()
            {
                Id = detail.Id,
                CarID = detail.CarID,
                Name = detail.Name
            };
            repository.Update(detailUpdate);
        }
    }
}
