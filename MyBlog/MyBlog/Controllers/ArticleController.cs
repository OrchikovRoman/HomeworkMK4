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
using ClassLibrary2.Models;

namespace MyBlog.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _service;

        public ArticleController()
        {
            _service = new ArticleService();
        }
        // GET: Article
        public ActionResult Index()
        {
            var config = new MapperConfiguration(con => con.CreateMap<ArticleModel, ArticleViewModel>());
            var mapper = new Mapper(config);
            var articles = mapper.Map<List<ArticleViewModel>>(_service.GetArticles());
            ViewBag.Message = "Articles";
            return View(articles);
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            var config = new MapperConfiguration(con =>
            {
                con.CreateMap<ArticleModel, ArticleViewModel>();
                con.CreateMap<AuthorModel, AuthorViewModel>();
                con.CreateMap<TagModel, TagViewModel>();
                con.CreateMap<CategoryModel, CategoryViewModel>();
            });

            var mapper = new Mapper(config);

            var artcle = mapper.Map<ArticleViewModel>(_service.GetArticles().FirstOrDefault(x => x.Id == id));

            ViewBag.Message = "Article";
            return View(artcle);
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(ArticleViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                var config = new MapperConfiguration(x => x.CreateMap<ArticleViewModel, ArticleModel>());
                var mapper = new Mapper(config);
                ArticleModel result = mapper.Map<ArticleViewModel, ArticleModel>(model);
                _service.Create(result);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ArticleViewModel article)
        {
            try
            {
                var config = new MapperConfiguration(x => x.CreateMap<ArticleViewModel, ArticleModel>());
                var mapper = new Mapper(config);
                ArticleModel res = mapper.Map<ArticleViewModel, ArticleModel>(article);
                _service.Update(res);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ArticleViewModel article)
        {
            try
            {
                _service.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

}