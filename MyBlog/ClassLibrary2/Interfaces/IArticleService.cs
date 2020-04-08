using BlogBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Interfaces
{
    public interface IArticleService 
    {
        IEnumerable<ArticleModel> GetArticles();
        ArticleModel GetById(int id);
        void Delete(int id);
        void Update(ArticleModel article);
        void Create(ArticleModel article);
    }
}
