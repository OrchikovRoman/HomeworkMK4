using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BuisnessLogicLayer
{
    public class DetailServices : IDetailServices
    {
        IDetailsRepository repository = new DetailsRepository();

        public IEnumerable<DetailModel> GetDetailModels()
        {
            var detailModels = from det in repository.GetDetails()
                               select new DetailModel() { Id = det.Id, CarID = det.CarID, NameDetail = det.NameDetail };
            return detailModels;
        }
    }
}
