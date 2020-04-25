using ModuleBLMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBLMVC.ResponseInterfaces
{
    public interface ICategoryApiService
    {
        IList<CategoryModel> GetAll();
        CategoryModel GetById(int id);
    }
}
