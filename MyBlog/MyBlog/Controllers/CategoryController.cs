using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ClassLibrary2.Interfaces;
using ClassLibrary2.Models;
using ClassLibrary2.Services;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _service;
        public CategoryController()
        {
            _service = new CategoryService();
        }
        // GET: Category
        public ActionResult Index()
        {
            var config = new MapperConfiguration(x => x.CreateMap<CategoryModel, CategoryViewModel>());
            var mapper = new Mapper(config);
            var categories = mapper.Map<IEnumerable<CategoryViewModel>>(_service.GetCategories());
            ViewBag.Massage = "Categories";
            return View(categories);
        }
    }
}