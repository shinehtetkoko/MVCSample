using System.ComponentModel.DataAnnotations;

namespace MVCSample.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Employee Number")]
        public int EmployeeNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
