﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Article> ArticlesCateg { get; set; }
        public Category()
        {
            ArticlesCateg = new List<Article>();
        }

    }
}