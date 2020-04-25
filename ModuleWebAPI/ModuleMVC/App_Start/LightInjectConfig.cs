using AutoMapper;
using LightInject;
using ModuleBLMVC.Interfaces;
using ModuleBLMVC.ResponseInterfaces;
using ModuleBLMVC.Responses;
using ModuleBLMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace ModuleMVC.App_Start
{
    public static class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();
            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new WebAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container.Register<ICategoryService, CategoryService>();
            container.Register<IProductService, ProductService>();
            container.Register<IProductApiService, ProductApiService>();
            container.Register<ICategoryApiService, CategoryApiService>();

            container.EnableMvc();
        }
    }
}