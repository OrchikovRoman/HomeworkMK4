using AutoMapper;
using ModuleBL.Models;
using ModuleWebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuleWebAPI.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<CategoryModel, CategoryViewModel>().ReverseMap();
            CreateMap<CategoryViewModel, CategoryModel>().ReverseMap();

            CreateMap<ProductModel, ProductViewModel>().ReverseMap();
            CreateMap<ProductViewModel, ProductModel>().ReverseMap();
        }
    }
}