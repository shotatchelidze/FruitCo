using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fruit.Models;

namespace Fruit.ViewModels
{
    public class InformationViewModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
                
        public string Subtitle { get; set; }

        public string Text { get; set; }
    }
}