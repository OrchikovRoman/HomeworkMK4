using BlogBL.Interfaces;
using BlogDAL.Intrerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Services
{
    public abstract class GenereicService<Model, T> : IGenericService<Model> where T : class where Model : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenereicService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Model> GetAll()
        {
            var ModelList = _repository.GetAll().ToList();
            return Map(ModelList);
        }
        public abstract Model Map(T entity);
        public abstract T Map(Model blmodel);

        public abstract IEnumerable<Model> Map(IList<T> entity);
        public abstract IEnumerable<T> Map(IList<Model> entity);
    }
}
