using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Intrerfaces
{
    public interface IGenericRepository<T> where  T: class
    {
        void Create(T item);
        void Update(T item);
        IEnumerable<T> GetAll();
        void Delete(int id);
        T GetById(int id);
    }
}
