using BlogBL.Interfaces;
using BlogBL.Models;
using BlogDAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogDAL.Intrerfaces;
using ClassLibrary1.Repositories;

namespace BlogBL.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _repository;

        public ArticleService()
        {
            _repository = new ArticleRepository();
        }

        public void Create(ArticleModel article)
        {
            if (IsValid(article) == false)
                throw new Exception("Please change the title name, this title name is already taken!");
            else
            {
                var config = new MapperConfiguration(x => x.CreateMap<ArticleModel, Article>());
                var mapper = new Mapper(config);
                Article result = mapper.Map<ArticleModel, Article>(article);
                _repository.Create(result);
            }
        }
        private bool IsValid(ArticleModel article)
        {
            if (_repository.GetByName(article.Title) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<ArticleModel> GetArticles()
        {
            var config = new MapperConfiguration(x => x.CreateMap<Article, ArticleModel>());
            var mapper = new Mapper(config);
            var articles = mapper.Map<IEnumerable<ArticleModel>>(_repository.GetArticles());
            return articles;
        }

        public ArticleModel GetById(int id)
        {
            var config = new MapperConfiguration(x => x.CreateMap<Article, ArticleModel>());
            var mapper = new Mapper(config);
            var article = mapper.Map<ArticleModel>(_repository.GetById(id));
            return article;
        }

        public void Update(ArticleModel article)
        {
            var config = new MapperConfiguration(x => x.CreateMap<ArticleModel, Article>());
            var mapper = new Mapper(config);
            Article res = mapper.Map<ArticleModel, Article>(article);
            _repository.Update(res);
        }
    }
}
