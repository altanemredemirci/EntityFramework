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
        #region** Sql Connection String Options
        //  1-Windows Authentication : 
        //  2-Sql Server Authentication: username password
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=202-3\\SQLDERS; Database=EShopper; Integrated Security=True; TrustServerCertificate=True"); // Windows Authentication

            optionsBuilder.UseSqlServer("Server=202-3\\SQLDERS; Database=EShopper; user Id=sa; password=1; TrustServerCertificate=True"); // Windows Authentication

        }
        #endregion



        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
