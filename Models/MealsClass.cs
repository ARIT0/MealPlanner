using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MealPlanner.Models
{
    public class MealsClass
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public int RecipesId { get; set; }
        [ForeignKey("RecipesId")]
        public RecipeClass RecipeClass { get; set; }

        [Display(Name = "Meal Type")]
        public string MealType { get; set; }

        //[DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }


    }
}
