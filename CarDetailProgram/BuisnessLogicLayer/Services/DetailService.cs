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
    public class DetailService : IDetailService
    {
        private IDetailRepository repository;

        public DetailService()
        {
            repository = new DetailRepository();
        }

        public IEnumerable<DetailModel> GetDetails()
        {
            var detailModels = from det in repository.GetDetails()
                               select new DetailModel() { Id = det.Id, CarID = det.CarID, NameDetail = det.NameDetail };
            return detailModels;
        }
    }
}
