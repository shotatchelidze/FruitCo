using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Fruit.Models;
using Fruit.ViewModels;

namespace Fruit.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Information, InformationViewModel>();
            Mapper.CreateMap<Container, ContainerViewModel>();


            Mapper.CreateMap<InformationViewModel, Information>();
            Mapper.CreateMap<ContainerViewModel, Container>();

        }
    }
}