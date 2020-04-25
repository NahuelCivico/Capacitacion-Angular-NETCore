using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.API.DTO;

namespace Todo.API.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CategoryDTO, Domain.Category>();
            CreateMap<Domain.Category, Data.Entities.Category>().ReverseMap();
        }
    }
}
