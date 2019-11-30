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
            Mapper.CreateMap<Ingredient, IngredientViewModel>();
            Mapper.CreateMap<Image, GalleryPhotoViewModel>();


            Mapper.CreateMap<InformationViewModel, Information>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<IngredientViewModel, Ingredient>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<GalleryPhotoViewModel, Image>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            
        }
    }
}