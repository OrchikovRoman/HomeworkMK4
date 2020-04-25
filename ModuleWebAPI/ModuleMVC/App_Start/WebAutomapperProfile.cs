using AutoMapper;
using ModuleBLMVC.Models;
using ModuleMVC.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModuleMVC.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<ProductData, ProductModel>()
           .ForMember(x => x.CategoryModel, y => y.MapFrom(x => x.CategoryData))
           .ReverseMap();

            CreateMap<CategoryData, CategoryModel>().ReverseMap();
        }
    }
}