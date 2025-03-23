﻿// <auto-generated />
using BylkyWeb_RazorTemp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BylkyWeb_RazorTemp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BylkyWeb_RazorTemp.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DisplayOrder = 5,
                            Name = "Chicken"
                        },
                        new
                        {
                            ID = 2,
                            DisplayOrder = 3,
                            Name = "Food"
                        },
                        new
                        {
                            ID = 3,
                            DisplayOrder = 2,
                            Name = "Fruti"
                        },
                        new
                        {
                            ID = 4,
                            DisplayOrder = 7,
                            Name = "Vegetable"
                        },
                        new
                        {
                            ID = 5,
                            DisplayOrder = 1,
                            Name = "Softdrink"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
