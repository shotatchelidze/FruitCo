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
            ContainerViewModelList = new List<ContainerViewModel>();
        }

        public List<InformationViewModel> InformationViewModelList { get; set; }
        public List<ContainerViewModel> ContainerViewModelList { get; set; }
    }
}