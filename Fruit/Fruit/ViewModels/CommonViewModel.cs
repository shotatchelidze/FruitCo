using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fruit.ViewModels
{
    public class CommonViewModel
    {
        public List<InformationViewModel> InformationViewModel { get; set; }
        public List<ContainerViewModel> ContainerViewModel { get; set; }
    }
}