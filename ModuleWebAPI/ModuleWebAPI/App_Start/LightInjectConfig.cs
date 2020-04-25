using AutoMapper;
using LightInject;
using ModuleBL.Configs;
using ModuleBL.Interfaces;
using ModuleBL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace ModuleWebAPI.App_Start
{
    public class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();
            container.RegisterApiControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new WebAutomapperProfile(), new BLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLightInjectConfiguration.Configuration(container);

            container.Register<IProductService, ProductService>();
            container.Register<ICategoryService, CategoryService>();
            

            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}