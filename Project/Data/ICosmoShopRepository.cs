using CosmoShop.Data.Entities;
using System.Collections.Generic;

namespace CosmoShop.Data
{
    public interface ICosmoShopRepository
    {
        IEnumerable<BaseProduct> GetAllProducts();
        IEnumerable<BaseProduct> GetProductsByCategory(string category);
        bool SaveChanges();
    }
}