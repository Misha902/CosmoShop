using CosmoShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmoShop.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly CosmoShopContext _context;

        public OrderRepository(CosmoShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAllOrder()
        {
            return _context.Orders
                           .OrderBy(o => o.Id)
                           .ToList();
        }
        public Order GetOrderById(int id)
        {
            return _context.Orders.Where(o => o.Id == id).First();
        }
        public void AddOrder(Order model)
        {
            _context.Add(model);
        }
    }
}
