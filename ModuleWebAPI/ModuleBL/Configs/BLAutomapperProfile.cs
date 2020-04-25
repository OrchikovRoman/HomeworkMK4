using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ModuleBL.Models;
using ModuleDAL.Entities;

namespace ModuleBL.Configs
{
    public class BLAutomapperProfile : Profile
    {
        public BLAutomapperProfile()
        {
            CreateMap<ProductModel, Product>().ReverseMap();
            CreateMap<Product, ProductModel>().ReverseMap();

            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<Category, CategoryModel>().ReverseMap();
        }
    }
}
