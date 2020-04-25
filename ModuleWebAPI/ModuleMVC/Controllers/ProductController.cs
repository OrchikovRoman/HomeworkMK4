using AutoMapper;
using ModuleBLMVC.Interfaces;
using ModuleMVC.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ModuleMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductService _service;
        private readonly ICategoryService _categoryService;
        public ProductController() { }

        public ProductController(IProductService service, IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _service = service;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var products = _service.GetAll();
            var productsModel = _mapper.Map<IEnumerable<ProductData>>(products);
            return View(productsModel);
        }

        public ActionResult Details(int id)
        {
            var products = _service.GetById(id);
            var productsModel = _mapper.Map<ProductData>(products);

            return View(productsModel);
        }

        public ActionResult ProductCategories(int? categoryId)
        {
            var products = _service.GetAll();
            var productsModel = _mapper.Map<IEnumerable<ProductData>>(products);

            if (categoryId != null && categoryId != 0)
            {
                productsModel = productsModel.Where(x =>x.CategoryId  == categoryId);
            }

            var categories = _categoryService.GetAll();
            var categoriesModel = _mapper.Map<IEnumerable<CategoryData>>(categories);

            ProductList productsList = new ProductList
            {
                Products = productsModel,
                Categories = new SelectList(categoriesModel, "Id", "Name ")
            };

            return View(productsList);
        }
    }
}
