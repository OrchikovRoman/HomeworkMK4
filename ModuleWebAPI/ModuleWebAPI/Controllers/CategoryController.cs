using AutoMapper;
using ModuleBL.Interfaces;
using ModuleBL.Models;
using ModuleWebAPI.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ModuleWebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        private ICategoryService _service;
        private IMapper _mapper;
        public CategoryController(ICategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Category
        public IEnumerable<CategoryViewModel> Get()
        {
            var categoryBL = _service.GetAll();
            var categoryPL = _mapper.Map<IEnumerable<CategoryViewModel>>(categoryBL);
            return categoryPL;
        }

        //GET: api/Category/5
        public CategoryViewModel Get(int id)
        {
            var categoryBL = _service.GetById(id);
            var categoryPL = _mapper.Map<CategoryViewModel>(categoryBL);
            return categoryPL;
        }

        // POST: api/Category
        public void Post([FromBody]CategoryViewModel category)
        {
            var categoryPL = _mapper.Map<CategoryModel>(category);
            _service.Create(categoryPL);
        }

        // PUT: api/Category/5
        [HttpPut]
        public void Put([FromBody]CategoryViewModel category)
        {
            var categoryPL = _mapper.Map<CategoryModel>(category);
            _service.Update(categoryPL);
        }

        // DELETE: api/Category/5
        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
