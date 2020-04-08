using AutoMapper;
using BlogBL.Models;
using BlogDAL.Models;
using ClassLibrary1.Intrerfaces;
using ClassLibrary1.Repositories;
using ClassLibrary2.Interfaces;
using ClassLibrary2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService()
        {
            _repository = new CategoryRepository();
        }

        public IEnumerable<CategoryModel> GetCategories()
        {
            var mapConfig = new MapperConfiguration(x =>
            {
                x.CreateMap<Category, CategoryModel>();
                x.CreateMap<Article, ArticleModel>();
            });
            var mapper = new Mapper(mapConfig);
            var categories = mapper.Map<IEnumerable<CategoryModel>>(_repository.GetCategories());
            return categories;
        }
    }
}
