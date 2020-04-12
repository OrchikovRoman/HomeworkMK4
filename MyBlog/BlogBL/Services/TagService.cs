using AutoMapper;
using BlogBL.Models;
using BlogDAL.Entities;
using BlogDAL.Intrerfaces;
using BlogDAL.Repositories;
using BlogBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBL.Services
{
    public class TagService : GenericService<TagModel, Tag>, ITagService
    {
        private IMapper _mapper;

        public TagService(IGenericRepository<Tag> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override TagModel Map(Tag entity)
        {
            return _mapper.Map<TagModel>(entity);
        }

        public override Tag Map(TagModel blmodel)
        {
            return _mapper.Map<Tag>(blmodel);
        }

        public override IEnumerable<TagModel> Map(IList<Tag> entities)
        {
            return _mapper.Map<IEnumerable<TagModel>>(entities);
        }

        public override IEnumerable<Tag> Map(IList<TagModel> models)
        {
            return _mapper.Map<IEnumerable<Tag>>(models);
        }
    }
}
