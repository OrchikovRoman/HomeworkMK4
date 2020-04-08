using BlogDAL;
using BlogDAL.Models;
using ClassLibrary1.Intrerfaces;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly MyContext _ctx;
        public TagRepository()
        {
            _ctx = new MyContext();
        }
        public IEnumerable<Tag> GetTags()
        {
            var res = _ctx.Tags.ToList();
            return res;
        }
    }
}
