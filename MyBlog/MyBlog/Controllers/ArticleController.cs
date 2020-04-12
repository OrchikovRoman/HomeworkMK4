using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Services;
using BlogBL.Models;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _service;
        private IMapper _mapper;

        public ArticleController(IArticleService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: Article
        public ActionResult Index()
        {
            var articleBL = _service.GetAll().ToList(); //Normal Date 
            var articlePL = _mapper.Map<IEnumerable<ArticleViewModel>>(articleBL); //Default Date
            return View(articlePL);
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            var postsBL = _service.GetById(id);
            var postsPL = _mapper.Map<ArticleViewModel>(postsBL);

            return View(postsPL);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(ArticleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<ArticleModel>(model);
            _service.Create(modelBL);
            return RedirectToAction("Index");
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ArticleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<ArticleModel>(model);
            _service.Update(modelBL);
            return RedirectToAction("Index");
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ArticleViewModel model)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }

}