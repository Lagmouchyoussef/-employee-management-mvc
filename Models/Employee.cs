using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCCoreEmsi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(255)]
        [Display(Name = "Position")]
        public string? Position { get; set; }
    }
}