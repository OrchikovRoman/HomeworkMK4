using AutoMapper;
using ModuleBLMVC.Interfaces;
using ModuleBLMVC.Responses;
using ModuleMVC.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModuleMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _service;

        public CategoryController() { }

        public CategoryController(ICategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var categories = _service.GetAll();
            var categoriesModel = _mapper.Map<IEnumerable<CategoryData>>(categories);
            return View(categoriesModel);
        }

        public ActionResult Details(int id)
        {
            var category = _service.GetById(id);
            var categoryModel = _mapper.Map<CategoryData>(category);

            return View(categoryModel);
        }
    }
}