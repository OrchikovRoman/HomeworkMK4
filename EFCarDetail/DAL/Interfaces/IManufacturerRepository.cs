using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IManufacturerRepository
    {
        IEnumerable<Manufacturer> GetAll();
        Manufacturer GetById(int id);
    }
}
