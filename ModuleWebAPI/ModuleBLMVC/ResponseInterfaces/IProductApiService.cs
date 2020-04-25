using ModuleBLMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBLMVC.ResponseInterfaces
{
    public interface IProductApiService
    {
        IList<ProductModel> GetAll();
        ProductModel GetById(int id);
    }
}
