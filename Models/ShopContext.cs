using Microsoft.EntityFrameworkCore;

namespace ders2.Models {
    public class ShopContext : DbContext {
        public ShopContext() { }
        public ShopContext(DbContextOptions<ShopContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB5_OGRT\\SQLEXPRESS01;Database=ShopDB;User Id=sa;Password=123;TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
       public DbSet<Category> Categories { get; set; }

    }
}