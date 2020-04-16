using AutoMapper;
using BlogBL.Models;
using MyBlog.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.WebAPI.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<CategoryModel, CategoryData>().ReverseMap();
            CreateMap<CategoryData, CategoryModel>().ReverseMap();

            CreateMap<ArticleModel, ArticleData>().ReverseMap();
            CreateMap<ArticleData, ArticleModel>().ReverseMap();

            CreateMap<TagModel, TagData>().ReverseMap();
            CreateMap<TagData, TagModel>().ReverseMap();

            CreateMap<AuthorModel, AuthorData>().ReverseMap();
            CreateMap<AuthorData, AuthorModel>().ReverseMap();

        }
    }
}