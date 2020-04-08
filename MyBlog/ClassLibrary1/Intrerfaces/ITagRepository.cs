using BlogDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Intrerfaces
{
    public interface ITagRepository
    {
        IEnumerable<Tag> GetTags();
    }
}
