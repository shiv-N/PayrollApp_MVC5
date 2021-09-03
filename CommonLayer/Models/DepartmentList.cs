using System.ComponentModel.DataAnnotations;

namespace EmployeePayrollApp.Models
{
    public class DepartmentList
    {
        [Display(Name = "HR")]
        public bool IsHR { get; set; }
        
        [Display(Name = "Sales")]
        public bool IsSales { get; set; }
        
        [Display(Name = "Finance")]
        public bool IsFinance { get; set; }
        
        [Display(Name = "Engineer")]
        public bool IsEngineer { get; set; }

        [Display(Name = "Others")]
        public bool IsOthers { get; set; }
    }
}