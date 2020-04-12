using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Article> Articles { get; set; }
        public Author()
        {
            Articles = new List<Article>();
        }
    }
}
