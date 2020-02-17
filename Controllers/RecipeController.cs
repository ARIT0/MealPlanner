using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MealPlanner.Models;
using MealPlanner.Data;
using MealPlanner.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Microsoft.AspNetCore.Http;

namespace MealPlanner.Controllers
{
    public class RecipeController : Controller
    {
        //TODO link to the db
        //ApplicationDbContext db = new ApplicationDbContext();
        private readonly ApplicationDbContext context;
        public RecipeController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
                       
        //GET: All Recipes
        public IActionResult Index()
        {

            List<RecipeClass> recipeIndex = context.Recipes.ToList();
            return View(recipeIndex); //TODO Link to all recipes RecipeIndex
        }

        
        public IActionResult Add()
        {
            NewRecipeVM addRecipeViewModel = new NewRecipeVM();
            return View(addRecipeViewModel);
        }
        
        //[Authorize] 
        [HttpPost]
        public IActionResult Add(NewRecipeVM obj)
        {
            int? uid = HttpContext.Session.GetInt32("UID");
            int uid2 = uid.Value;

            if (ModelState.IsValid)
            {
                //RecipeClass newRecipe = context.Recipes.Single(c => c.RecId == obj.RecId);
                TagsClass t = new TagsClass
                {
                    TagName = obj.TagName
                };
                context.Tags.Add(t);
                context.SaveChanges();


                RecipeClass r = new RecipeClass
                {
                    RecName = obj.RecName,
                    TagsId = t.Id, 
                    UserId = uid2 
                    //Calories = obj.Calories
                };
                context.Recipes.Add(r);
                context.SaveChanges();
                                            
                             
                InstructionsClass inst = new InstructionsClass
                {   
                    RecipeId = r.Id,
                    StepOrder = obj.StepOrder,
                    Instruct = obj.Instruct
                };
                context.Instructions.Add(inst);
                context.SaveChanges();
                              
                IngredientsClass ing = new IngredientsClass
                { 
                    IngName = obj.IngName,
                    UM = obj.UM
                    //Id = ingQ.Id
                };
                context.Ingredients.Add(ing);
                context.SaveChanges();

                IngQuantClass ingQ = new IngQuantClass
                {
                    RecipeClassId = r.Id,
                    IngredientsClassId = ing.Id,
                    Quantity = obj.Quantity
                    
                };
                context.IngQuant.Add(ingQ);
                context.SaveChanges();

                ViewBag.message = "Recipe created";
                
                return Redirect("/Index");
            }   

            return View(obj);
        }        
    }
}