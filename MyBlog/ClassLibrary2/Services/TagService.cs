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
    public class TagService : ITagService
    {
        private readonly ITagRepository _repository;

        public TagService()
        {
            _repository = new TagRepository();
        }

        public IEnumerable<TagModel> GetTags()
        {
            var mapConfig = new MapperConfiguration(x =>
            {
                x.CreateMap<Tag, TagModel>();
                x.CreateMap<Article, ArticleModel>();
            });
            var mapper = new Mapper(mapConfig);
            var tags = mapper.Map<IEnumerable<TagModel>>(_repository.GetTags());
            return tags;
        }
    }
}
