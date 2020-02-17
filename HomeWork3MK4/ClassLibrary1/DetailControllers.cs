using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuisnessLogicLayer;

namespace PresentatinLayer
{
    public class DetailControllers : IDetailControllers
    {
        IDetailServices services = new DetailServices();

        public IEnumerable<DetailViewModel> GetDetailViewModels()
        {
            var detailViewModels = from det in services.GetDetailModels()
                                   select new DetailViewModel() { Id = det.Id, Cars_Id = det.CarID, NameDetail = det.NameDetail };
            return detailViewModels;
        }
    }
}
