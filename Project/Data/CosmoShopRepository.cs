using CosmoShop.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CosmoShop.Data
{
    public class CosmoShopRepository : ICosmoShopRepository
    {
        private readonly CosmoShopContext _context;

        public CosmoShopRepository(CosmoShopContext context)
        {
            _context = context;
        }

        public IEnumerable<BaseProduct> GetAllProducts()
        {
            return _context.BaseProducts
                           .OrderBy(p => p.Name)
                           .ToList();
        }
        public IEnumerable<BaseProduct> GetProductsByCategory(string category)
        {
            return _context.BaseProducts
                           .Where(p => p.Category == category)
                           .ToList();
        }
        public bool SaveChanges()
        {
            return _context.SaveChanges() > 1;
        }
    }
}
