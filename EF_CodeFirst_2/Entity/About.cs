using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_2.Entity
{
    internal class About
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Text { get; set; }

        public string ImageUrl { get; set; }
    }
}
