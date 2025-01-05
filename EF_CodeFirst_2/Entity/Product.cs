using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_2.Entity
{
    internal class Product
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        public double Price { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public int Stock { get; set; }
        public List<Images> images { get; set; }
    }
}
