using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MealPlanner.Models;
using Microsoft.AspNetCore.Authentication;
//using Microsoft.Owin.Security.Cookies;

namespace MealPlanner.Controllers
{
    public class HomeController : Controller
    {
        //private readonly SignInAsync<User> _si;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /*
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login()
        {

        }*/
    }
}
