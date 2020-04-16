using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.WebAPI.Models
{
    public class ArticleData
    {
        public int Id { get; set; }
        [MinLength(2), Required]
        public string Title { get; set; }
        [MinLength(2), Required]
        public string Txt { get; set; }
        public string Img { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateArticle { get; set; }


        public int AuthorId { get; set; }
        public AuthorData AuthorData { get; set; }
        public IEnumerable<TagData> Tags { get; set; }
        public IEnumerable<CategoryData> Categories { get; set; }
    }
}