using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fruit.ViewModels
{
    public class CommonViewModel
    {
        public CommonViewModel()
        {
            InformationViewModelList = new List<MainPageViewModel>();
            IngredientViewModelList = new List<IngredientViewModel>();
        }

        public List<MainPageViewModel> InformationViewModelList { get; set; }
        public List<IngredientViewModel> IngredientViewModelList { get; set; }
        public List<ImageViewModel> GalleryPhotoViewModels { get; set; }
    }
}