using eLaptops.Models;
using Microsoft.EntityFrameworkCore;

namespace eLaptops.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Features_Laptop>().HasKey(fl => new
            {
                fl.FeatureID,
                fl.LaptopID
            });

            modelBuilder.Entity<Features_Laptop>().HasOne(l => l.Laptop).WithMany(fl => fl.Features_Laptops).HasForeignKey(l => l.LaptopID);
            modelBuilder.Entity<Features_Laptop>().HasOne(l => l.Features).WithMany(fl => fl.Features_Laptops).HasForeignKey(l => l.FeatureID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet <Features> Features { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Features_Laptop> Features_Laptops { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
