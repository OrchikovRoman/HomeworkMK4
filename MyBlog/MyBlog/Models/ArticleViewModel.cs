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
        [Required]
        public string Title { get; set; }
        [Required]
        public string Txt { get; set; }
        public string Img { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime DataArticle { get; set; }
       

        public int AuthorId { get; set; }
        public AuthorViewModel AuthorViewModel { get; set; }
        public IEnumerable<TagViewModel> Tags { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}