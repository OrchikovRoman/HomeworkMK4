using ModuleBLMVC.Models;
using ModuleBLMVC.ResponseInterfaces;
using ModuleBLMVC.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBLMVC.Interfaces
{
    public interface IProductService : IProductApiService
    {
        IEnumerable<ProductModel> GetByIdCategory(int id);
    }
}
