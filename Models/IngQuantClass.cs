using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanner.Models
{
    public class IngQuantClass
    {
        [Key]
        public int Id { get; set; }
        
        public int RecipeClassId { get; set; }
        [ForeignKey("RecipeClassId")]
        public RecipeClass RecipeClass { get; set; }
        
        public int IngredientsClassId { get; set; }
        [ForeignKey("IngredientsClassId")]
        public IngredientsClass IngredientsClass { get; set; }
        
        [Required(ErrorMessage = "Please Enter Quantity")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        //public RecipeClass RecipeClass { get; set; }
        //public ICollection<IngredientsClass> Ingredients { get; set; } //= new List<IngredientsClass>();
    }
}

