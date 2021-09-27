using CosmoShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CosmoShop.Data
{
    public class CosmoShopContext : IdentityDbContext<StoreUser>
    {
        public CosmoShopContext(DbContextOptions<CosmoShopContext> options)
            : base(options)
        {
         //   Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<SpaceObject> SpaceObjects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
