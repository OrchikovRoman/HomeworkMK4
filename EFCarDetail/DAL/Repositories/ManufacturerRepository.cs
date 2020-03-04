using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly CarDetailsContext _db;

        public ManufacturerRepository()
        {
            _db = new CarDetailsContext();
        }
        public IEnumerable<Manufacturer> GetAll()
        {
            return _db.Manufacturers.AsNoTracking().ToList();
        }

        public Manufacturer GetById(int id)
        {
            return _db.Manufacturers.FirstOrDefault(x => x.Id == id);
        }
    }
}
