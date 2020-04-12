using BlogBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogBL.Models;
using BlogBL.Services;
using AutoMapper;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _service;
        private IMapper _mapper;

        public AuthorController(IAuthorService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var usersBL = _service.GetAll().ToList();
            var usersPL = _mapper.Map<IEnumerable<AuthorViewModel>>(usersBL);

            return View(usersPL);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var usersBL = _service.GetById(id);
            var usersPL = _mapper.Map<AuthorViewModel>(usersBL);

            return View(usersPL);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(AuthorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<AuthorModel>(model);
            _service.Create(modelBL);
            return RedirectToAction("Index");
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AuthorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<AuthorModel>(model);
            _service.Update(modelBL);
            return RedirectToAction("Index");
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, AuthorViewModel model)
        {
            // TODO: Add delete logic here
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}