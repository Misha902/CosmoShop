using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CosmoShop.Data;
using CosmoShop.Services;
using CosmoShop.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CosmoShop.Data.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CosmoShop.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly ICosmoShopRepository _context;

        public AppController(IMailService mailService, ICosmoShopRepository context)
        {
            _mailService = mailService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact";   
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Shop(int? category, string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 4;
            
            var spaceObjects = category is null || category == 0 ? _context.GetAllProducts() : _context.GetProductsByCategory(Convert.ToInt32(category));
            
            if (!String.IsNullOrEmpty(name))
            {
                spaceObjects = spaceObjects.Where(p => p.Name.ToLower().Contains(name.ToLower()));
            }

            var count = spaceObjects.Count();
            var items = spaceObjects.Skip((page - 1) * pageSize).Take(pageSize);

            //spaceObjects = sortOrder switch
            //{
            //    SortState.PriceAsc => spaceObjects.OrderBy(s => s.Price),
            //    SortState.PriceDesc => spaceObjects.OrderByDescending(s => s.Price),
            //    _ => spaceObjects.OrderBy(s => s.Name),
            //};           

            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                //SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(_context.GetAllCategories().ToList(), category, name),
                SpaceObjects = items
            };
            return View(viewModel);
        }
        public IActionResult Show(int id)
        {

            return View("Show", _context.GetProductById(id));
        }
    }
}
