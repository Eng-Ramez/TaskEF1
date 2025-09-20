using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEF1.Models
{
    internal class Category
    {
        [Key]
        public int catId { get; set; }
        public string Name { get; set; }
        
    }
}
