using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DetailRepository : IDetailRepository
    {
        private readonly CarDetailsContext _ctx;
        public DetailRepository()
        {
            _ctx = new CarDetailsContext();
        }

        public void Create(Detail detail)
        {
            _ctx.Detail.Add(detail);
            _ctx.SaveChanges();
        }

        public void Delete(int Id)
        {
            _ctx.Detail.Remove(_ctx.Detail.FirstOrDefault(x => x.Id == Id));
            _ctx.SaveChanges();
        }

        public Detail GetById(int id)
        {
            return _ctx.Detail.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Detail> GetDetails()
        {
            return _ctx.Detail.AsNoTracking().ToList();
        }

        public void Update(Detail detail)
        {
            var updateDet = _ctx.Detail.FirstOrDefault(x => x.Id == detail.Id);
            updateDet.Id = detail.Id;
            updateDet.Name = detail.Name;
            updateDet.CarID = detail.CarID;
            updateDet.Price = detail.Price;
            _ctx.SaveChanges();
        }
    }
}
