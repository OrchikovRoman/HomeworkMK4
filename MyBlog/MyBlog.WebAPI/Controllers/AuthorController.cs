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
    public class AuthorController : ApiController
    {
        private IAuthorService _service;
        private IMapper _mapper;
        public AuthorController(IAuthorService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public AuthorController() { }
        // GET: api/Author
        public IEnumerable<AuthorData> Get()
        {
            var authorsBL = _service.GetAll();
            var authorsPL = _mapper.Map<IEnumerable<AuthorData>>(authorsBL);
            return authorsPL;
        }


        // GET: api/Author/5
        public AuthorData Get(int id)
        {
            var authorBL = _service.GetById(id);
            var authorPL = _mapper.Map<AuthorData>(authorBL);
            return authorPL;
        }

        // POST: api/Author
        public void Post([FromBody]AuthorData author)
        {
            var authorPL = _mapper.Map<AuthorModel>(author);
            _service.Create(authorPL);
        }

        // PUT: api/Author/5
        [HttpPut]
        public void Put([FromBody]AuthorData author)
        {
            var authorPL = _mapper.Map<AuthorModel>(author);
            _service.Update(authorPL);
        }

        // DELETE: api/Author/5
        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
