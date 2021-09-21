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

        public IEnumerable<SpaceObject> GetAllProducts()
        {
            return _context.SpaceObjects
                           .OrderBy(p => p.Name)
                           .ToList();
        }
        public IEnumerable<SpaceObject> GetProductsByCategory(string category)
        {
            return _context.SpaceObjects
                           .Where(p => p.Category == category)
                           .ToList();
        }
        public bool SaveChanges()
        {
            return _context.SaveChanges() > 1;
        }
    }
}
