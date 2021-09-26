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

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                _mailService.SendMessage("zawesky111@gmail.com", model.Message.ToString());
                ModelState.Clear();
            }
            else
            {
            
            }
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Shop(int page = 1)
        {
            int pageSize = 12;

            IEnumerable<SpaceObject> source = _context.GetAllProducts();
            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize);

            var pageViewModel = new PageViewModel(count, page, pageSize);
            var viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
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
