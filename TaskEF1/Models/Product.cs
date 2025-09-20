using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEF1.Models
{
    internal class Product
    {
        
        public int? Id { get; set; }
        [Column (TypeName="Varchar(50)")]
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double? Rate { get; set; }


    }
}
