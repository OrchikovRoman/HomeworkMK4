using ClassLibrary2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ClassLibrary2.Services;
using ClassLibrary2.Models;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class TagController : Controller
    {
        private readonly ITagService _service;
        public TagController()
        {
            _service = new TagService();
        }
        // GET: Tag
        public ActionResult Index()
        {
            var config = new MapperConfiguration(x => x.CreateMap<TagModel, TagViewModel>());
            var mapper = new Mapper(config);
            var tags = mapper.Map<List<TagViewModel>>(_service.GetTags());
            ViewBag.Message = "Articles";
            return View(tags);
        }
    }
}