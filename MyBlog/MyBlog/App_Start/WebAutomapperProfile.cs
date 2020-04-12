using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BlogBL.Models;
using MyBlog.Models;

namespace MyBlog.App_Start
{
    public class WebAutomapperProfile : Profile
    {
        public WebAutomapperProfile()
        {
            CreateMap<CategoryModel, CategoryViewModel>().ReverseMap();
            CreateMap<CategoryViewModel, CategoryModel>().ReverseMap();

            CreateMap<ArticleModel, ArticleViewModel>().ReverseMap();
            CreateMap<ArticleViewModel, ArticleModel>().ReverseMap();

            CreateMap<TagModel, TagViewModel>().ReverseMap();
            CreateMap<TagViewModel, TagModel>().ReverseMap();

            CreateMap<AuthorModel, AuthorViewModel>().ReverseMap();
            CreateMap<AuthorViewModel, AuthorModel>().ReverseMap();
        }
    }
}