using Microsoft.AspNetCore.Mvc;
using CosmoShop.Data;
using CosmoShop.Data.Entities;
using CosmoShop.ViewModels;

namespace CosmoShop.Controllers
{
    [Route("api/[Controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(_orderRepository.GetAllOrder());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOrdersById(int id)
        {
            return Ok(_orderRepository.GetOrderById(id));
        }

        [HttpPost]
        public IActionResult AddOrder(Order model)
        {
            _orderRepository.AddOrder(model);
            return Ok();
        }
    }
}
