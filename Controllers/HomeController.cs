using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using reg_login.Models;
using Microsoft.AspNetCore.Http;

namespace reg_login.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(User myUser)
        {
            if (ModelState.IsValid)
            {
                List<User> NewList = new List<User>();
                HttpContext.Session.SetObjectAsJson("myUser", myUser);

                return RedirectToAction("About", myUser);
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult About(User myUser)
        {
            return View(myUser);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
