using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPlanner.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        
        [Required(ErrorMessage = "Please Enter Name...")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Please Enter Last Name...")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter a Username...")]
        [Display(Name ="User Name")]
        //[Index(IsUnique = true)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter a Password...")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Confirm Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string Confirmpwd { get; set; }
    }
}
