using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Entities

{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Txt { get; set; }
        public string Img { get; set; }
        public DateTime DateArticle { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public ICollection<Tag> Tags { get; set; }
        public ICollection<Category> Categories { get; set; }

        public Article()
        {
            Tags = new List<Tag>();
            Categories = new List<Category>();
        }
    }
}
