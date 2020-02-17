using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.AspNetCore.Http;
using MealPlanner.Models;
using MealPlanner.Data;


namespace MealPlanner.Controllers
{
    public class MealPlanController : Controller
    {

        private readonly ApplicationDbContext context;
        public MealPlanController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pick()
        {

            List<RecipeClass> recipeIndex = context.Recipes.ToList();
            return View(recipeIndex); //TODO Link to all recipes RecipeIndex
        }

        public JsonResult GetMeals()
        {

            int? uid = HttpContext.Session.GetInt32("UID");
            int uid2 = uid.Value;
            
            
            var meals = context.Meals.ToList();
            return new JsonResult (new { Data = meals});   
            

            //return new JsonResult(new { Data = meals });if (uid2 >= 0){}
            
        }

        public IActionResult ShoppingList()
        {

        }
    }
}