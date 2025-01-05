﻿// <auto-generated />
using EF_CodeFirst_2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_CodeFirst_2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250105123315_CreateDatabase2")]
    partial class CreateDatabase2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_CodeFirst_2.Relations.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaxId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EF_CodeFirst_2.Relations.Tax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("TaxNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Taxs");
                });

            modelBuilder.Entity("EF_CodeFirst_2.Relations.Customer", b =>
                {
                    b.HasOne("EF_CodeFirst_2.Relations.Tax", "Tax")
                        .WithOne("Customer")
                        .HasForeignKey("EF_CodeFirst_2.Relations.Customer", "TaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tax");
                });

            modelBuilder.Entity("EF_CodeFirst_2.Relations.Tax", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
