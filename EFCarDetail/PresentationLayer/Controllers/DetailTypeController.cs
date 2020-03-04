using BuisnessLogicLayer.Interfaces;
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
    public class DetailTypeController : IDetailTypeController
    {
        public IEnumerable<DetailTypeViewModel> GetAll()
        {
            IDetailTypeService detailTypesService = new DetailTypeService();

            var types = detailTypesService.GetAll();

            var result = types.Select(x => new DetailTypeViewModel
            {
                Id = x.Id,
                Name = x.Name
            });
            return result;
        }
    }
}
