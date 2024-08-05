
using CollegeApp.Validators;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class StudentDTO
    {
        
        public int Id { get; set; }
        [Required (ErrorMessage = "Student name is required")]
        public string StudentName { get; set; }

        [EmailAddress (ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
       
    }
}
