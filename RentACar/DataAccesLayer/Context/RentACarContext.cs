using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class RentACarContext : DbContext
    {
        public RentACarContext(DbContextOptions<RentACarContext> options) : base(options)
        { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<About> Abaouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            // Car - Brand
            modelBuilder.Entity<Car>().HasOne(c => c.Brand).WithMany(c => c.Cars).HasForeignKey(c => c.BrandId).OnDelete(DeleteBehavior.Cascade);
            // Car - Image
            modelBuilder.Entity<CarImage>().HasOne(i => i.Car).WithMany(i => i.Images).HasForeignKey(i => i.CarId).OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }
    }
}
