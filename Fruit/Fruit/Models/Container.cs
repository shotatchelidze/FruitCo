using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fruit.Models
{
    public class Container
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar"),MaxLength(50)]
        public string Name { get; set; }
    }
}