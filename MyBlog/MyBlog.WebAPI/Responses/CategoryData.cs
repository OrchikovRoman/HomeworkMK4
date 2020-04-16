using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.WebAPI.Models
{
    public class CategoryData
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<ArticleData> Articles { get; set; }
    }
}