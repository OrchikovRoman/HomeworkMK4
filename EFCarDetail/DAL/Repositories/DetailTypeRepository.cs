using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DetailTypeRepository : IDetailTypeRepository
    {
        public IEnumerable<DetailType> GetAll()
        {
            using (var ctx = new CarDetailsContext())
            {
                return ctx.DetailTypes.AsNoTracking().ToList();
            }
        }
    }
}
