﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fruit.Models
{
    public class Image
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string PageName { get; set; }

        public string ImagePath { get; set; }

        public int SortIndex { get; set; }



        public virtual MainPage MainPage { get; set; }
    }
}