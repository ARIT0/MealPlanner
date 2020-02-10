using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MealPlanner.Models
{
    public class IngredientsClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter the Ingredient Name")]
        [Display(Name = "Ingredient Name")]
        public string IngName { get; set; }

        [Required(ErrorMessage = "Please Enter Unit of Measure")]
        [Display(Name = "Unit of Measure")] 
        public string UM { get; set; }

        public IngQuantClass IngQuantClass { get; set; }
        //public ICollection<IngQuantClass> Quantity { get; set; }
        
    }
}
