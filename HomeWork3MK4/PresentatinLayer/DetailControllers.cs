using System;
using System.Collections.Generic;
using System.Text;

namespace PresentatinLayer
{
    public class DetailControllers : IDetailControllers
    {
        IDetailServices services = new DetailServices();

        public IEnumerable<DetailViewModel> GetDetailViewModels()
        {
            var detailViewModels = from det in services.GetDetailModels()
                                   select new DetailViewModel() { Id = det.Id, Cars_Id = det.Cars_Id, NameDetail = det.NameDetail };
            return detailViewModels;
        }
    }
}
