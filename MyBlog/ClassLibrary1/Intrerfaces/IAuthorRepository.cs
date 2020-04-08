using BlogDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Intrerfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAuthors();
    }
}
