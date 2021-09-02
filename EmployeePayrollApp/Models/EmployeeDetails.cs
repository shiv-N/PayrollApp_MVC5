using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeePayrollApp.Models
{
    public class EmployeeDetails
    {
        [Required]
        [RegularExpression(pattern:@"^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$",
            ErrorMessage = "Please enter valid name.")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Profile image")]
        public string ProfileImage { get; set; }

        [Required]
        [RegularExpression("Male|Female", ErrorMessage = "The Gender must be either 'Male' or 'Female' only.")]
        public string Gender { get; set; }

        [Required]
        public DepartmentList Department { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        public string Notes { get; set; }
    }
}