using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BuisnessLogicLayer
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
