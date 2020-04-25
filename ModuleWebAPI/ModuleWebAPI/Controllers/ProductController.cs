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
    public class ProductController : ApiController
    {
        private IProductService _service;

        private IMapper _mapper;

        public ProductController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Product
        public IEnumerable<ProductViewModel> Get()
        {
            var productBL = _service.GetAll();
            var productPL = _mapper.Map<IEnumerable<ProductViewModel>>(productBL);
            return productPL;
        }

        // GET: api/Product/5
        public ProductViewModel Get(int id)
        {
            var productBL = _service.GetById(id);
            var productPL = _mapper.Map<ProductViewModel>(productBL);
            return productPL;
        }

        // POST: api/Product
        public void Post([FromBody]ProductViewModel product)
        {
            var productPL = _mapper.Map<ProductModel>(product);
            _service.Create(productPL);
        }

        // PUT: api/Product/5
        [HttpPut]
        public void Put([FromBody]ProductViewModel product)
        {
            var productPL = _mapper.Map<ProductModel>(product);
            _service.Update(productPL);
        }

        // DELETE: api/Product/5
        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
