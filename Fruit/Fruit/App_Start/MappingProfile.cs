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
            Mapper.CreateMap<MainPage, MainPageViewModel>();
            Mapper.CreateMap<Ingredient, IngredientViewModel>();
            Mapper.CreateMap<Image, ImageViewModel>();


            Mapper.CreateMap<MainPageViewModel, MainPage>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<IngredientViewModel, Ingredient>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<ImageViewModel, Image>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            
        }
    }
}