using CosmoShop.Data.Entities;
using System.Collections.Generic;

namespace CosmoShop.Data
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrder();
        Order GetOrderById(int id);
        void AddOrder(Order model);
    }
}