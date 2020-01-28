using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MealPlanner.Models;
using MealPlanner.Data;
using MealPlanner.ViewModels;


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


        public IActionResult AddRecipe()
        {
            NewRecipeVM addRecipeViewModel = new NewRecipeVM();
            return View(addRecipeViewModel);
        }
        
        [HttpPost]
        public IActionResult AddRecipe(NewRecipeVM obj)
        {
            if (ModelState.IsValid)
            {
                RecipeClass r = new RecipeClass
                {
                    RecName = obj.RecName,
                    //Calories = obj.Calories
                };

                InstructionsClass inst = new InstructionsClass
                {
                    StepOrder = obj.StepOrder,
                    Instruct = obj.Instruct,
                    //RecId = obj.RecId
                };

                IngredientsClass ing = new IngredientsClass
                { 
                    IngName = obj.IngName,
                    UM = obj.UM
                };

                IngQuantClass ingQ = new IngQuantClass
                {
                    Quantity = obj.Quantity,
                };

                TagsClass t = new TagsClass
                {
                    TagName = obj.TagName
                };

                context.Recipes.Add(r);
                context.Instructions.Add(inst);
                context.Ingredients.Add(ing);
                context.IngQuant.Add(ingQ);
                context.Tags.Add(t);
                context.SaveChanges();
                
                return Redirect("/Index");
            }   

            return View(obj);
        }        
    }
}