using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MealPlanner.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MealPlanner.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using MealPlanner.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using System.Web;


//using Microsoft.Owin.Security.Cookies;

namespace MealPlanner.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            return View("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Login(User user) //login from the homepage
        {
           
            bool isUserExists = context.UserRegistration
                .Any(u => u.Username == user.Username && u.Password == user.Password);
            
            int ui = context.UserRegistration
                    .Where(x=>x.Username == user.Username)
                    .Select(x=>x.UserId)
                    .FirstOrDefault();

            if (isUserExists)
            {
                HttpContext.Session.SetString("Username", user.Username);
                //int sessionID = Session["UserID"];
                HttpContext.Session.SetInt32("UID", ui);
                //Session["Username"] = user.Username.ToString();
                //Session["UID"] = user.UserId;
                ViewBag.Username = HttpContext.Session.GetString("Username");
                int? uid = HttpContext.Session.GetInt32("UID");
                
                return View("LoggedIn");
            }
            else
            {
                ViewBag.Fail = "Invalid Credentials";
                return View();
            }                                 
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult LogOut()
        {
            //removes cookie with the authentication handler
            //HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); 
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
