using BizBook.Common.Library.Models;
using BizBook.Products.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BizBook.Products.Api.Models.Db
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
        {
            
        }

        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=BizBookProductDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.BuildIndex<ProductGroup>();
            modelBuilder.BuildIndex<ProductCategory>();
            modelBuilder.BuildIndex<ProductDetail>();
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<ProductGroup> ProductGroups { get; set; }

        public virtual DbSet<ProductCategory> ProductCategories { get; set; }

        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
