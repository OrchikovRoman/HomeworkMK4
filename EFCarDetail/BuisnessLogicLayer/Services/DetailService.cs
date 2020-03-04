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
                Id = detail.Id,
                CarID = detail.CarID,
                Name = detail.Name,
                Price = detail.Price
            };
            repository.Create(detailCreate);
        }

        public void Delete(int Id)
        {
            repository.Delete(Id);
        }

        public DetailModel GetById(int Id)
        {
            var model = repository.GetById(Id);

            var detailModel = new DetailModel
            {
                Id = model.Id,
                Name = model.Name,
                CarID = model.CarID,
                Price = model.Price
            };
            return detailModel;
        }

        public IEnumerable<DetailModel> GetDetails()
        {
            var detailModels = repository.GetDetails().Select(x => new DetailModel
            {
                Id = x.Id,
                Name = x.Name,
                CarID = x.CarID,
                Price = x.Price
            });
            return detailModels;
        }

        public void Update(DetailModel detail)
        {
            var detailUpdate = new Detail()
            {
                Id = detail.Id,
                CarID = detail.CarID,
                Name = detail.Name,
                Price = detail.Price
            };
            repository.Update(detailUpdate);
        }
    }
}
