using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fruit.Dto
{
    public class InformationDto
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(1000)]
        public string Subtitle { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Text { get; set; }
    }
}