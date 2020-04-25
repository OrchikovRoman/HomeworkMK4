using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModuleMVC.Responses
{
    public class ProductList
    {
        public IEnumerable<ProductData> Products { get; set; }
        public SelectList Categories { get; set; }
    }
}