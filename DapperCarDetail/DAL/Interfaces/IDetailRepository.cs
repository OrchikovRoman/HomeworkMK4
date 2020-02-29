using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDetailRepository
    {
        IEnumerable<Detail> GetDetails();
        void Create(Detail detail);
        void Update(Detail detail);
        void Delete(Detail detail);
        Detail GetById(int id);
    }
}
