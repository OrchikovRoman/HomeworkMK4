using ModuleBLMVC.Responses;
using ModuleBLMVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleBLMVC.ResponseInterfaces;

namespace ModuleBLMVC.Services
{
    public class CategoryService : CategoryApiService, ICategoryService
    {
        public CategoryService(ICategoryApiService apiService)
        {
        }
    }
}
