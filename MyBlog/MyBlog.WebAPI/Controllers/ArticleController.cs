using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Models;
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
        public ArticleController() { }

        // GET: api/Article
        public IEnumerable<ArticleData> Get()
        {
            var articlesBL = _service.GetAll();
            var articlePL = _mapper.Map<IEnumerable<ArticleData>>(articlesBL);
            return articlePL;
        }

        // GET: api/Article/5
        public ArticleData Get(int id)
        {
            var articleBL = _service.GetById(id);
            var articlePL = _mapper.Map<ArticleData>(articleBL);
            return articlePL;
        }

        // POST: api/Article
        public void Post([FromBody]ArticleData article)
        {
            var articlePL = _mapper.Map<ArticleModel>(article);
            _service.Create(articlePL);
        }

        // PUT: api/Article/5
        [HttpPut]
        public void Put([FromBody]ArticleData article)
        {
            var articlePL = _mapper.Map<ArticleModel>(article);
            _service.Update(articlePL);
        }

        // DELETE: api/Article/5
        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
