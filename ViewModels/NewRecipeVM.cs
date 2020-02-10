using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MealPlanner.ViewModels
{
    public class NewRecipeVM
    {
        
        [Required(ErrorMessage = "Please Enter a Recipe Name")]
        [Display(Name = "Recipe Name")]
        public string RecName { get; set; }

        [Required(ErrorMessage = "Please Enter the Ingredient Name")]
        [Display(Name = "Ingredient Name")]
        public string IngName { get; set; }

        [Required(ErrorMessage = "Please Enter Quantity")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please Enter Unit of Measure")]
        [Display(Name = "Unit of Measure")]
        public string UM { get; set; }

        [Required(ErrorMessage = "Please Enter the Step Number")]
        [Display(Name = "Step Number")]
        public int StepOrder { get; set; }

        [Required(ErrorMessage = "Please Enter Instruction")]
        [Display(Name = "Instruction")]
        public string Instruct { get; set; }

        [Required(ErrorMessage = "Please Enter at least one tag")]
        [Display(Name = "Tags")]
        public string TagName { get; set; }
    }
}
