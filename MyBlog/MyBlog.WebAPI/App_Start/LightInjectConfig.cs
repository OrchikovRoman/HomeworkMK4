using AutoMapper;
using BlogBL.Configs;
using BlogBL.Interfaces;
using BlogBL.Services;
using LightInject;
using System.Collections.Generic;
using System.Reflection;

namespace MyBlog.WebAPI.App_Start
{
    public class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();
            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new WebAutomapperProfile(), new BLAutomapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLightInjectConfiguration.Configuration(container);

            container.Register<IArticleService, ArticleService>();
            container.Register<IAuthorService, AuthorService>();
            container.Register<ICategoryService, CategoryService>();
            container.Register<ITagService, TagService>();

            container.EnableMvc();
        }
    }
}