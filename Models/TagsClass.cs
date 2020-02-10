using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MealPlanner.Models
{
    public class TagsClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter at least one tag")]
        [Display(Name = "Tags")]
        public string TagName { get; set; }
        public ICollection<RecipeClass> Recipes { get; set; }
        
        //public RecipeClass RecipeClass { get; set; }
        //public IList<TagsClass> TagsClasses { get; set; }
    }
}
