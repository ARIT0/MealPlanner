using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MealPlanner.Models;



namespace MealPlanner.Models
{
    public class RecipeClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter a Recipe Name")]
        [Display(Name ="Recipe Name")]
        public string RecName { get; set; }

        [Display(Name ="Total Calories for Recipe")]
        public int Calories { get; set; }
        
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        
        //public string TagName { get; set; }

        public int TagsId { get; set; }
        [ForeignKey("TagsId")]
        public TagsClass TagsClass { get; set; }
        
        //public ICollection<TagsClass> Tags { get; set; }
        /*
        public int? TagIdfk { get; set; }
        [ForeignKey("TagIdfk")]
        public virtual TagsClass TagId { get; set; }*/
        
        /*public User User { get; set; }
         = new List<TagsClass>();
        public ICollection<InstructionsClass> Instructions { get; set; } = new List<InstructionsClass>();
        public ICollection<IngredientsClass> Ingredients { get; set; } = new List<IngredientsClass>();
        */

    }
}
