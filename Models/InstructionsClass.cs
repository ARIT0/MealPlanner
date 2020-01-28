using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanner.Models
{
    public class InstructionsClass
    {
        //[Key]
        public int? RecIdfk { get; set; }
        [ForeignKey("RecIdfk")]
        public virtual RecipeClass RecId { get; set; }

        [Required(ErrorMessage = "Please Enter the Step Number")]
        [Display(Name = "Step Number")]
        public int StepOrder { get; set; }

        [Required(ErrorMessage = "Please Enter Instruction")]
        [Display(Name = "Instruction")]
        public string Instruct { get; set; }
    }
}
                                                                                                                                                                                  