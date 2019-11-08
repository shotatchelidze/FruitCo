using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Fruit.Dto;
using Fruit.Models;

namespace Fruit.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Information, InformationDto>();


            Mapper.CreateMap<InformationDto, Information>();

        }
    }
}