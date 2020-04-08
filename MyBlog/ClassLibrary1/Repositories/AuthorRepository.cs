using BlogDAL.Intrerfaces;
using BlogDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly MyContext _ctx;
        public AuthorRepository()
        {
            _ctx = new MyContext();
        }
        public IEnumerable<Author> GetAuthors()
        {
            var res = _ctx.Authors.Include(x => x.Articles).ToList();
            return res;
        }
    }
}
