using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fruit.ViewModels
{
    public class ImageViewModel
    {
        public int Id { get; set; }

        public string PageName { get; set; }

        public string ImagePath { get; set; }

        public int SortIndex { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}