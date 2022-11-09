using BmxShopService.Models;
using Microsoft.EntityFrameworkCore;

namespace BmxShopService
{
    public class ShopContext: DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Deliveries> Deliveries { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Manufacturers> Manufacturers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<User> User { get; set; }   

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>(b =>
            {
                b.HasKey(d => d.id);
                b.HasMany(d => d.orderItems);
            });
            modelBuilder.Entity<Products>(b =>
            {
                b.HasKey(d => d.id);
                b.HasMany(d => d.orderItems);
                b.HasOne(d => d.manufacturer);
            });
            modelBuilder.Entity<Categories>(b =>
            {
                b.HasKey(d => d.id);
                b.HasMany(d => d.products);
            });
            modelBuilder.Entity<Manufacturers>(b =>
            {
                b.HasKey(d => d.Id);
                b.HasMany(d => d.products);
            });
        }
    }
}
