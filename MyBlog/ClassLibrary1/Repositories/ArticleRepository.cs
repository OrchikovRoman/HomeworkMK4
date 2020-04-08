using BlogDAL;
using BlogDAL.Models;
using BlogDAL.Intrerfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MyContext _ctx;
        public ArticleRepository()
        {
            _ctx = new MyContext();
        }
        public void Update(Article article)
        {
            _ctx.Entry(article).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public Article GetById(int id)
        {
            return _ctx.Articles.Find(id);
        }

        public Article GetByName(string Name)
        {
            return _ctx.Articles.FirstOrDefault(x => x.Title == Name);
        }

        public IEnumerable<Article> GetArticles()
        {
            var result = _ctx.Articles.ToList();
            return result;
        }

        public void Create(Article article)
        {
            _ctx.Articles.Add(article);
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            _ctx.Articles.Remove(GetById(id));
            _ctx.SaveChanges();
        }
    }
}
