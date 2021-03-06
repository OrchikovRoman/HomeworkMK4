﻿using BlogBL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Txt { get; set; }
        public string Img { get; set; }
        
        public DateTime DateArticle { get; set; }


        public int AuthorId { get; set; }
        public AuthorModel AuthorModel { get; set; }

        public IEnumerable<TagModel> Tags { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}
