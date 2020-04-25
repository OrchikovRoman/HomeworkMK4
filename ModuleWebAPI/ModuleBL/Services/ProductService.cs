using AutoMapper;
using ModuleBL.Interfaces;
using ModuleBL.Models;
using ModuleDAL.Entities;
using ModuleDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBL.Services
{
    public class ProductService : GenericService<ProductModel, Product>, IProductService
    {
        private IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override ProductModel Map(Product entity)
        {
            return _mapper.Map<ProductModel>(entity);
        }

        public override Product Map(ProductModel blmodel)
        {
            return _mapper.Map<Product>(blmodel);
        }

        public override IEnumerable<ProductModel> Map(IList<Product> entities)
        {
            return _mapper.Map<IEnumerable<ProductModel>>(entities);
        }

        public override IEnumerable<Product> Map(IList<ProductModel> models)
        {
            return _mapper.Map<IEnumerable<Product>>(models);
        }
    }
}
