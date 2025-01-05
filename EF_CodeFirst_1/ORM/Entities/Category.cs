using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_1.ORM.Entities
{
    [Table("Kategoriler")]
    internal class Category
    {
        //[Key]//PK
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Identity(1,1)
        //public string Barkod { get; set; }

        //Entity Framework paketini yüklediğinizde Id,id,ID,iD, vb.. tanımlarına direk olarak Primary Key ve Identity özelliklerini atar.
        public int Id { get; set; }


        // *** Attribute : nesne niteliklerini özelleştirmek için(sql kuralları) kullanılır. Üzerine yazıldığı niteliği etkiler.

        //[Required] //Not Null özelliği verir. Yazmasanızda default olarak zaten bu özellik atanır.
        //? : nullable özelliği verir.
        [StringLength(30)]
        public string? Name { get; set; }

        public List<Product> products { get; set; }

        public Category()
        {
            products = new List<Product>();
        }
    }
}
