using dev2.Data;
using dev2.Services;
using dev2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dev2.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly Dev2Context _context;

        public AppController(IMailService mailService, Dev2Context context)
        {
            _mailService = mailService;
           _context = context;
        }





        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        [HttpPost("Contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            ViewBag.Title = "Contact Us";
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("ing-cantor@hotmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message:{model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            else
            {
                //show error
            }
            return View();

        }
        [HttpGet("About")]
        public IActionResult About()
        {
            ViewBag.Title = "About US";
            return View();
        }


        public IActionResult Shop()
        {
            var results = from p in _context.Products
                          orderby p.Category
                        select p;

          return View(results.ToList());
        }



    }
}