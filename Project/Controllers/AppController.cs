using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CosmoShop.Data;
using CosmoShop.Services;
using CosmoShop.ViewModels;

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
        public IActionResult Shop()
        {          
            return View(_context.GetAllProducts());
        }
    }
}
