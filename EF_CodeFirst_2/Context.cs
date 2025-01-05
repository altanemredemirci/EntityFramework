using EF_CodeFirst_2.Entity;
using EF_CodeFirst_2.Relations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_2
{
    internal class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=202-3\\SQLDERS; Database=CompanyDB; user Id=sa; password=1; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         modelBuilder.Entity<Customer>()
        .HasOne(a => a.Tax)
        .WithOne(b => b.Customer)
        .HasForeignKey<Tax>(b => b.CustomerId);
        }

        //public DbSet<Product> Products { get; set; }
        //public DbSet<SocialMedia> SocialMedias  { get; set; }
        //public DbSet<Home> Homes  { get; set; }
        //public DbSet<About> Abouts  { get; set; }
        //public DbSet<Images> Images  { get; set; }
        //public DbSet<Contact> Contacts  { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Tax> Taxs { get; set; }

    }
}
