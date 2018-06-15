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
        private readonly IDev2Repository _repository;

        public AppController(IMailService mailService, IDev2Repository repository)
        {
            _mailService = mailService;
            _repository = repository;
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

        [HttpGet("Shop")]
        public IActionResult Shop()
        {
            var results = _repository.GetAllProducts();

          return View(results);
        }



    }
}