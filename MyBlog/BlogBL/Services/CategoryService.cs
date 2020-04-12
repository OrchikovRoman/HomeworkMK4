using AutoMapper;
using BlogBL.Models;
using BlogDAL.Entities;
using BlogDAL.Intrerfaces;
using BlogDAL.Repositories;
using BlogBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Services
{
    public class CategoryService : GenericService<CategoryModel, Category>, ICategoryService
    {
        private IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }
        public override CategoryModel Map(Category entity)
        {
            return _mapper.Map<CategoryModel>(entity);
        }

        public override Category Map(CategoryModel blmodel)
        {
            return _mapper.Map<Category>(blmodel);
        }

        public override IEnumerable<CategoryModel> Map(IList<Category> entities)
        {
            return _mapper.Map<IEnumerable<CategoryModel>>(entities);
        }

        public override IEnumerable<Category> Map(IList<CategoryModel> models)
        {
            return _mapper.Map<IEnumerable<Category>>(models);
        }
    }
}
