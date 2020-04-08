using AutoMapper;
using BlogBL.Models;
using BlogDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL
{
    public class BLAutomapperProfile : Profile
    {
        public BLAutomapperProfile()
        {
            CreateMap<ArticleModel, Article>().ReverseMap();
        }
    }
}
