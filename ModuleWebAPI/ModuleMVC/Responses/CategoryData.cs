using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModuleMVC.Responses
{
    public class CategoryData
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<ProductData> Products { get; set; }
    }
}