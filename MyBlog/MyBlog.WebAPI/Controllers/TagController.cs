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
    public class TagController : ApiController
    {
        private ITagService _service;
        private IMapper _mapper;
        public TagController(ITagService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public TagController() { }

        // GET: api/Tag
        public IEnumerable<TagData> Get()
        {
            var tagBL = _service.GetAll();
            var tagPL = _mapper.Map<IEnumerable<TagData>>(tagBL);
            return tagPL;
        }

        // GET: api/Tag/5
        public TagData Get(int id)
        {
            var tagBL = _service.GetById(id);
            var tagPL = _mapper.Map<TagData>(tagBL);
            return tagPL;
        }

        // POST: api/Tag
        public void Post([FromBody]TagData tag)
        {
            var tagPL = _mapper.Map<TagModel>(tag);
            _service.Create(tagPL);
        }

        // PUT: api/Tag/5
        [HttpPut]
        public void Put([FromBody]TagData tag)
        {
            var tagPL = _mapper.Map<TagModel>(tag);
            _service.Update(tagPL);
        }

        // DELETE: api/Tag/5
        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
