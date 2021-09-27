using CosmoShop.Data.Entities;
using System.Collections.Generic;

namespace CosmoShop.Data
{
    public interface ICosmoShopRepository
    {
        IEnumerable<SpaceObject> GetAllProducts();
        SpaceObject GetProductById(int id);
        IEnumerable<SpaceObject> GetProductsByCategory(int category);
        IEnumerable<Category> GetAllCategories();
        bool SaveChanges();
    }
}