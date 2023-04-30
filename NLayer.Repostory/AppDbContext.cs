// using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repostory
{
    /*
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // ctor cont -> construction
            // construction

            var p = new Product() { ProductFeature = new ProductFeature() { Color = "red" } };

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        //  public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  modelBuilder.Entity<Product>().HasKey(x => x.Id);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
    */
}
