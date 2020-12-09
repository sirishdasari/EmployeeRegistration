using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeRegistration.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(100, MinimumLength = 3)]
        public string EmpName { get; set; }
        public Design Designation { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        [Range(10000, 30000, ErrorMessage = "Salary must be between 10000 and 30000")]
        public string Salary { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Not a valid email address")]
        [Required(ErrorMessage = "Email Id Required!")]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^([7-9]{1})?([0-9]{9})$", ErrorMessage = "Entered phone format is not valid.")]
        public string Mobile { get; set; }
        public Qual Qualification { get; set; }
        public string Manager { get; set; }
    }

    public enum Qual
    {
        [Display(Name = "B.Tech")]
        Btech,
        [Display(Name = "M.Tech")]
        Mtech,
        [Display(Name = "MBA")]
        MBA
    }

    public enum Design
    {
        [Display(Name = "CEO")]
        CEO,
        [Display(Name = "Project Manager")]
        ProjectManager,
        [Display(Name = "Team Leader")]
        TeamLeader
    }
}