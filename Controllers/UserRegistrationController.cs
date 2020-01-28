using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MealPlanner.Models;
using MealPlanner.Data;

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
        public IActionResult Create(User uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.mesage = "The user " + uc.Username + " is saved successfully!";
            return View();
        }
    }
}