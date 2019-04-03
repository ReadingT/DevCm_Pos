using cm_pos.Models;
using Microsoft.EntityFrameworkCore;

namespace cm_pos.Database
{
    public class DatabaseContext : DbContext
    {
        internal object cm_product;

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductSize> ProductSize { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Naming convention snake case

            modelBuilder.Entity<ProductSize>().ToTable("Product_Size");
            //modelBuilder.Entity<Product>().ToTable("cm_product");

            modelBuilder.Entity<Product>(b =>
            {
                b.Property(p => p.ProductID).HasColumnName("Product_ID");
                b.Property(p => p.CategoryID).HasColumnName("Category_ID");
                b.Property(p => p.CodeName).HasColumnName("Code_Name");
            });

            modelBuilder.Entity<Category>(b =>
            {
                b.Property(c => c.CategoryID).HasColumnName("Category_ID");
            });

            modelBuilder.Entity<ProductSize>(b =>
            {
                b.Property(ps => ps.ProductID).HasColumnName("Product_ID");
            });

            // Default Value
            modelBuilder.Entity<Product>(b =>
            {
                b.Property(p => p.Timestamp).HasDefaultValueSql("getdate()");
                b.Property(p => p.Name).HasDefaultValue("unknows");
            });

            // Data Types
            modelBuilder.Entity<Product>(b =>
            {
                b.Property(p => p.Name).HasColumnType("varchar(200)");
            });

            // Required
            modelBuilder.Entity<Product>().Property(p => p.CodeName).IsRequired();
        } 
    }
}