using AutoMapper;
using BlogBL.Interfaces;
using BlogBL.Models;
using BlogDAL.Intrerfaces;
using BlogDAL.Entities;
using BlogDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Services
{
    public class AuthorService : GenericService<AuthorModel, Author>, IAuthorService
    {
        private IMapper _mapper;

        public AuthorService(IGenericRepository<Author> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override AuthorModel Map(Author entity)
        {
            return _mapper.Map<AuthorModel>(entity);
        }

        public override Author Map(AuthorModel blmodel)
        {
            return _mapper.Map<Author>(blmodel);
        }

        public override IEnumerable<AuthorModel> Map(IList<Author> entities)
        {
            return _mapper.Map<IEnumerable<AuthorModel>>(entities);
        }

        public override IEnumerable<Author> Map(IList<AuthorModel> models)
        {
            return _mapper.Map<IEnumerable<Author>>(models);
        }
    }
}
