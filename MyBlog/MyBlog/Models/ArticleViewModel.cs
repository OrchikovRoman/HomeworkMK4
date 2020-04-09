using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Txt { get; set; }
        public string Img { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Input date")]
        public DateTime DataArticle { get; set; }
       

        public int CategoryId { get; set; }
        public virtual CategoryViewModel Category { get; set; }

        public int AuthorId { get; set; }
        public virtual AuthorViewModel AuthorViewModel { get; set; }
        public IEnumerable<TagViewModel> Tags { get; set; }
    }
}