using ModuleBLMVC.Interfaces;
using ModuleBLMVC.Models;
using ModuleBLMVC.ResponseInterfaces;
using ModuleBLMVC.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBLMVC.Services
{
    public class ProductService : ProductApiService, IProductService
    {
        public ProductService(IProductApiService apiService)
        {

        }
        
        public IEnumerable<ProductModel> GetByIdCategory(int id)
        {
            var products = GetAll().Where(x => x.CategoryModel.Id == id);

            return products;
        }
    }
}
