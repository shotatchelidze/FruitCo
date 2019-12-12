using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fruit.Models;

namespace Fruit.ViewModels
{
    public class MainPageViewModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
                
        public string Subtitle { get; set; }

        public int ImageId { get; set; }

        public string PageName { get; set; }

        public string ImagePath { get; set; }

        public int SortIndex { get; set; }

    }
}