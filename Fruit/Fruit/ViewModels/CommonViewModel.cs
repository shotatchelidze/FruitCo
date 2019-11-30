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
            InformationViewModelList = new List<InformationViewModel>();
            IngredientViewModelList = new List<IngredientViewModel>();
        }

        public List<InformationViewModel> InformationViewModelList { get; set; }
        public List<IngredientViewModel> IngredientViewModelList { get; set; }
        public List<GalleryPhotoViewModel> GalleryPhotoViewModels { get; set; }
    }
}