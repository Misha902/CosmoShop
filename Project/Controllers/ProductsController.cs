using Microsoft.AspNetCore.Mvc;
using CosmoShop.Data;
using CosmoShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmoShop.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CosmoShop.Controllers
{
    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        private readonly ICosmoShopRepository _repository;

        public ProductsController(ICosmoShopRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repository.GetAllProducts());
            }
            catch
            {
                return BadRequest("Failed to get products");
            }
        }
    }
}
