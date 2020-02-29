using BuisnessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Interfaces
{
    public interface IDetailService
    {
        IEnumerable<DetailModel> GetDetails();
        void Create(DetailModel detail);
        void Delete(DetailModel detail);
        void Update(DetailModel detail);
        DetailModel GetById(int Id);
    }
}