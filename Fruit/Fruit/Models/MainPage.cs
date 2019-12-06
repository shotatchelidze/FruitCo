using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fruit.Models
{
    public class MainPage
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar"),MaxLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar"),MaxLength(1000)]
        public string Subtitle { get; set; }



        public virtual List<Image> Images { get; set; }
    }
}