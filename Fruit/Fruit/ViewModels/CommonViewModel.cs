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
            InformationViewModelList = new List<InformationViewModelList>();
            ContainerViewModelList = new List<ContainerViewModel>();
        }

        public List<InformationViewModelList> InformationViewModelList { get; set; }
        public List<ContainerViewModel> ContainerViewModelList { get; set; }
    }
}