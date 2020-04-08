using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Models;
using BlogDAL.Intrerfaces;
using BlogDAL.Models;
using BlogDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _repository;

        public AuthorService()
        {
            _repository = new AuthorRepository();
        }
        public IEnumerable<AuthorModel> GetAuthors()
        {
            var mapConfig = new MapperConfiguration(x =>
            {
                x.CreateMap<Author, AuthorModel>();
                x.CreateMap<Article, ArticleModel>();;
            });
            var mapper = new Mapper(mapConfig);
            var authors = mapper.Map<IEnumerable<AuthorModel>>(_repository.GetAuthors());
            return authors;
        }
    }
}
