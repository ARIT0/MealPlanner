using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MealPlanner.Models;
using MealPlanner.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Data.SqlClient;

namespace MealPlanner.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly ApplicationDbContext _auc;

        public UserRegistrationController(ApplicationDbContext auc)
        {
            _auc = auc;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Get Method
        public IActionResult Create () 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User uc)
        {
            //_auc.Password = Cryptography.Hash(uc.Password);
            _auc.Add(uc);
            try
            {               
               await _auc.SaveChangesAsync();                
            }
            catch (DbUpdateException e) //TODO if username select existing user throw error is appearing on another page
            
            when(e.InnerException?.InnerException is SqlException sqlEx &&
                     (sqlEx.Number == 2627)| sqlEx.Message.Contains("UniqueContraint"))                
            {               
               return View(ViewBag.Message = "That Username already exists.");               
            }
            
            ViewBag.message = "The user " + uc.Username + " is saved successfully!";
            return View();
        }
        /*
        private async Task<IActionResult> SignInUser(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Name, user.FirstName)
            };
            
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(principal);

            return RedirectToAction("Home", "Index");
        }*/
    }
}