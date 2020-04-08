using BlogDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Intrerfaces
{
    public interface IArticleRepository
    {
        Article GetById(int id);
        Article GetByName(string Name);
        IEnumerable<Article> GetArticles();
        void Create(Article article);
        void Delete(int id);
        void Update(Article article);
    }
}
