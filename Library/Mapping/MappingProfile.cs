using AutoMapper;
using Library.Data.DTO;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookInfoViewModel, BookInfoDTO>();
            CreateMap<BookInfoDTO, BookInfoViewModel>();
        }
    }
}
