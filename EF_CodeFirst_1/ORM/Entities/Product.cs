﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_1.ORM.Entities
{
    internal class Product
    {
        public int Id { get; set; }

        [MaxLength(30),MinLength(5)]
        public string Name { get; set; }
        public double Price { get; set; }
        [Range(1,100)]
        public int Stock { get; set; }

        //Relation Mapping 1-N OneToMany ilişki kurduk. 
        // Her ürün bir kategorisi vardır.
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
