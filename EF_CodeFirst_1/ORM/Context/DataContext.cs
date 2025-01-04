using EF_CodeFirst_1.ORM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_1.ORM.Context
{
    //bağlantı yapısının ve özelliklerinin EF ile tanımlanması istendi.
    internal class DataContext:DbContext
    {
        //Sql Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=202-3\\SQLDERS; Database=EShopper; Integrated Security=True; TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }

    }
}
