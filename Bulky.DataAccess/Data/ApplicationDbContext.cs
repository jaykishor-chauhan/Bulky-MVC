using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID=1,Name="Chicken", DisplayOrder=5},
                new Category { ID=2,Name="Food", DisplayOrder=3},
                new Category { ID=3,Name="Fruti", DisplayOrder=2},
                new Category { ID=4,Name="Vegetable", DisplayOrder=7},
                new Category { ID=5,Name="Softdrink", DisplayOrder=1}
            );
        }

    }
}
