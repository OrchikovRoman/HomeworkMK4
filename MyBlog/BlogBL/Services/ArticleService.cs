using BlogBL.Interfaces;
using BlogBL.Models;
using BlogDAL.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogDAL.Intrerfaces;
using BlogDAL.Repositories;

namespace BlogBL.Services
{
    public class ArticleService : GenericService<ArticleModel, Article>, IArticleService
    {
        private IMapper _mapper;

        public ArticleService(IGenericRepository<Article> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override ArticleModel Map(Article entity)
        {
            return _mapper.Map<ArticleModel>(entity);
        }

        public override Article Map(ArticleModel blmodel)
        {
            return _mapper.Map<Article>(blmodel);
        }

        public override IEnumerable<ArticleModel> Map(IList<Article> entities)
        {
            return _mapper.Map<IEnumerable<ArticleModel>>(entities);
        }

        public override IEnumerable<Article> Map(IList<ArticleModel> models)
        {
            return _mapper.Map<IEnumerable<Article>>(models);
        }
    }
}
