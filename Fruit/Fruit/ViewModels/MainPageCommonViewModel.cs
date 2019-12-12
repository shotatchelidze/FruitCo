using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fruit.Models;
using Fruit.ViewModels;

namespace Fruit.ViewModels
{
    public class MainPageCommonViewModel
    {
        public List<MainPageViewModel> MainPageViewModel { get; set; }
        public List<ImageViewModel> ImageViewModel { get; set; }

        public MainPageCommonViewModel()
        {
            this.MainPageViewModel = new List<MainPageViewModel>();
            this.ImageViewModel = new List<ImageViewModel>();
        }
    }
}