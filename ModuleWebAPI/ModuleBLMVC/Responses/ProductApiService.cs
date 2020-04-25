using ModuleBLMVC.Models;
using ModuleBLMVC.ResponseInterfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleBLMVC.Responses
{
    public class ProductApiService : IProductApiService
    {
        private readonly RestClient _restClient;
        private string apiURL = "api/Product";
        public ProductApiService()
        {
            _restClient = new RestClient("http://local.modulewebapi");
        }
        public IList<ProductModel> GetAll()
        {
            var request = new RestRequest(apiURL);
            var responseData = _restClient.Execute<List<ProductModel>>(request, Method.GET).Data;
            return responseData;
        }

        public ProductModel GetById(int id)
        {
            var apiURLId = $"api/Product/{id}";
            var request = new RestRequest(apiURL);
            var resposeData = _restClient.Execute<List<ProductModel>>(request, Method.GET).Data;
            var responseItem = resposeData.FirstOrDefault(x => x.Id == id);
            return responseItem;
        }
    }
}
