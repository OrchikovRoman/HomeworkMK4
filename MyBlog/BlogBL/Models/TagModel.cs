using BlogBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Models
{
    public class TagModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ArticleModel> Articles { get; set; }
    }
}
