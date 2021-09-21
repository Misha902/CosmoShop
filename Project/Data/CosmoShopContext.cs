using CosmoShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CosmoShop.Models;

namespace CosmoShop.Data
{
    public class CosmoShopContext : IdentityDbContext<StoreUser>
    {
        public CosmoShopContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<PlanetarySystem> PlanetarySystems { get; set; }
        public DbSet<BaseProduct> BaseProducts { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CosmoShopDb;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true;");
        }
    }
}
