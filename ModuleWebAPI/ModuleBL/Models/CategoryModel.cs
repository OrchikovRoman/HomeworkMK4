using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBL.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductModel> Products { get; set; }

        public CategoryModel()
        {
            Products = new List<ProductModel>();
        }
    }
}
