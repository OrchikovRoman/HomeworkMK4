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
    public class CategoryApiService : ICategoryApiService
    {
        private readonly RestClient _restClient;
        private string apiURL = "api/Category";
        public CategoryApiService()
        {
            _restClient = new RestClient("http://local.modulewebapi");
        }
        public IList<CategoryModel> GetAll()
        {
            var request = new RestRequest(apiURL);
            var responseData = _restClient.Execute<List<CategoryModel>>(request, Method.GET).Data;
            return responseData;
        }

        public CategoryModel GetById(int id)
        {
            var apiURLId = $"api/Category/{id}";
            var request = new RestRequest(apiURL);
            var resposeData = _restClient.Execute<List<CategoryModel>>(request, Method.GET).Data;
            var responseItem = resposeData.FirstOrDefault(x => x.Id == id);
            return responseItem;
        }
    }
}
