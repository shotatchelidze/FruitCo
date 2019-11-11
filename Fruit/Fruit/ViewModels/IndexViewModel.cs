using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fruit.ViewModels
{
    public class IndexViewModel
    {
        public int ContainerId { get; set; }

        public string Name { get; set; }

        public int InformationId { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Text { get; set; }
    }
}