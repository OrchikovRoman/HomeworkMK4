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
    public class DetailTypeService : IDetailTypeService
    {
        public IEnumerable<DetailTypeModel> GetAll()
        {
            IDetailTypeRepository detailTypesRepository = new DetailTypeRepository();

            var types = detailTypesRepository.GetAll();

            var result = types.Select(x => new DetailTypeModel
            {
                Id = x.Id,
                Name = x.Name
            });
            return result;
        }
    }
}
