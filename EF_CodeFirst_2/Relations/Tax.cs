using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_2.Relations
{
    internal class Tax
    {
        public int Id { get; set; }
        public int TaxNumber { get; set; }

        //Mapping OneToOne 1-1 ilişki
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
