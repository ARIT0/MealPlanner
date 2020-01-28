using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanner.Models
{
    public class RecipeClass
    {
        [Key]
        public int RecId { get; set; }

        [Required(ErrorMessage ="Please Enter a Recipe Name")]
        [Display(Name ="Recipe Name")]
        public string RecName { get; set; }

        [Display(Name ="Total Calories for Recipe")]
        public int Calories { get; set; }
        public int UserId { get; set; }
        
        public int? TagIdfk { get; set; }
        [ForeignKey("TagIdfk")]
        public virtual TagsClass TagId { get; set; }
    }
}
