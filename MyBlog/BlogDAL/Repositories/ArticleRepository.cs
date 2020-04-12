using BlogDAL;
using BlogDAL.Entities;
using BlogDAL.Intrerfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Repositories
{
    public class ArticleRepository : GenericRepository<Article>
    {
    }
}
