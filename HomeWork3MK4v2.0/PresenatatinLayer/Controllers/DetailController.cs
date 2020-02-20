using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuisnessLogicLayer;

namespace PresentatinLayer
{
    public class DetailController : IDetailController
    {
        private IDetailService service; 

        public DetailController()
        {
            service = new DetailService();
        }
        public IEnumerable<DetailViewModel> GetDetails()
        {
            var detailViewModels = from det in service.GetDetails()
                                   select new DetailViewModel() { Id = det.Id, Cars_Id = det.CarID, NameDetail = det.NameDetail };
            return detailViewModels;
        }
    }
}
