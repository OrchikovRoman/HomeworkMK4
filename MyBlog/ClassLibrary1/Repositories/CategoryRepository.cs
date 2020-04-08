using BlogDAL;
using BlogDAL.Models;
using System.Data.Entity;
using ClassLibrary1.Intrerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MyContext _ctx;
        public CategoryRepository()
        {
            _ctx = new MyContext();
        }
        public IEnumerable<Category> GetCategories()
        {
            var res = _ctx.Categories.ToList();
            return res;
        }
    }
}
