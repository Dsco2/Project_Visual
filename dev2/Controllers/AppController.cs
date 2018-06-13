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