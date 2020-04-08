using BlogDAL.Intrerfaces;
using BlogDAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightInject;
using BlogDAL;

namespace BlogBL
{
    //public static class BLLightInjectCongiguration
    //{
    //    public static ServiceContainer Congiguration(ServiceContainer container)
    //    {
    //        container.Register(typeof(MyContext<>), typeof(MyContext<>));
    //        //container.Register<DbContext>(factory => new DbContext(@"Data Source=.\SQLEXPRESS;Initial Catalog=WebDB;Integrated Security=True"));
    //        container.Register(typeof(IGenericRepository<>), typeof(GenericRepository<>));
    //        return container;
    //    }
    //}
}
