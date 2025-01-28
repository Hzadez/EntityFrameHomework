using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameHomework.Class;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameHomework
{
    public class AppDbContext : DbContext
    {
        public DbSet<Brand>Brand { get; set; }
        public DbSet<Color>Color { get; set; }
        public DbSet<Car>Car { get; set; }
        public DbSet<Model>Model { get; set; }
        public DbSet<CarAndColor> CarAndColor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZEYNAL\\SQLEXPRESS;Database=EntityFrameHomework;Trusted_Connection=true;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
