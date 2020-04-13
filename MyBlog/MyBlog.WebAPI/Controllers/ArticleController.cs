using AutoMapper;
using BlogBL.Interfaces;
using MyBlog.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyBlog.WebAPI.Controllers
{
    public class ArticleController : ApiController
    {
        private IArticleService _service;

        private IMapper _mapper;

        public ArticleController(IArticleService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Article
        public IEnumerable<ArticleViewModel> Get()
        {
            var articlesBL = _service.GetAll();
            var articlePL = _mapper.Map<IEnumerable<ArticleViewModel>>(articlesBL);
            return articlePL;
        }

        // GET: api/Article/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Article
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Article/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Article/5
        public void Delete(int id)
        {
        }
    }
}
