using AutoMapper;
using BlogBL.Models;
using BlogDAL.Entities;

namespace BlogBL.Configs
{
    public class BLAutomapperProfile : Profile
    {
        public BLAutomapperProfile()
        {
            CreateMap<ArticleModel, Article>().ReverseMap();
            CreateMap<Article, ArticleModel>().ReverseMap();

            CreateMap<TagModel, Tag>().ReverseMap();
            CreateMap<Tag, TagModel>().ReverseMap();

            CreateMap<AuthorModel, Author>().ReverseMap();
            CreateMap<Author, AuthorModel>().ReverseMap();

            CreateMap<CategoryModel, Category>().ReverseMap();
            CreateMap<Category, CategoryModel>().ReverseMap();
        }

    }
}
