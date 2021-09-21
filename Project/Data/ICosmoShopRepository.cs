using CosmoShop.Data.Entities;
using System.Collections.Generic;

namespace CosmoShop.Data
{
    public interface ICosmoShopRepository
    {
        IEnumerable<SpaceObject> GetAllProducts();
        IEnumerable<SpaceObject> GetProductsByCategory(string category);
        bool SaveChanges();
    }
}