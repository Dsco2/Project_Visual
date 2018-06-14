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

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
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
    }
}