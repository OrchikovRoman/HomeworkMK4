using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interfaces
{
    public interface IGenericService<Model> where Model: class
    {
        IEnumerable<Model> GetAll();
    }
}
