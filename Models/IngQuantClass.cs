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
        
        public int? RecIdfk { get; set; }
        [ForeignKey("RecIdfk")]
        public virtual RecipeClass RecId { get; set; }


        public int? IngIdfk { get; set; }
        [ForeignKey("IngIdfk")]
        public virtual IngredientsClass IngId { get; set; }


        [Required(ErrorMessage = "Please Enter Quantity")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

    }
}

