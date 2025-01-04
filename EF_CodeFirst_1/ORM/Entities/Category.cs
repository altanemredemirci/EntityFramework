using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_1.ORM.Entities
{
    internal class Category
    {
        //[Key]//PK
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Identity(1,1)
        //public string Barkod { get; set; }

        //Entity Framework paketini yüklediğinizde Id,id,ID,iD, vb.. tanımlarına direk olarak Primary Key ve Identity özelliklerini atar.
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
