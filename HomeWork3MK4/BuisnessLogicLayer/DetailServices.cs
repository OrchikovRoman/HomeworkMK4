using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogicLayer
{
    public class DetailServices : IDetailServices
    {
        IDetailsRepository repository = new DetailsRepository();

        public IEnumerable<DetailModel> GetDetailModels()
        {
            var detailModels = from det in repository.GetDetails()
                               select new DetailModel() { Id = det.Id, Cars_Id = det.Cars_Id, NameDetail = det.NameDetail };
            return detailModels;
        }
    }
