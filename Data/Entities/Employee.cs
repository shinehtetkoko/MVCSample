using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCSample.Data.Entities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [Required]
        public int EmployeeNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmployeeName { get; set; } = string.Empty;

        [Required]
        public int Gender { get; set; }

        [Required]
        public int MaritalStatus { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nrc { get; set; } = string.Empty; 

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int Position { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public DateTime HiredDate { get; set; }

        public DateTime? TerminationDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Qualification { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string WorkPhone { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string WorkEmail { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? CurrentAddress { get; set; }

        [MaxLength(20)]
        public string? PersonalPhone { get; set; }

        [MaxLength(50)]
        public string? PersonalEmail { get; set; }

        [MaxLength(100)]
        public string? PermanentAddress { get; set; }

        [Required]
        public int UserRole { get; set; }

        [Required]
        public bool EmploymentStatus { get; set; } = true;

        [Required]
        [MaxLength(20)]
        public string Password { get; set; } = string.Empty;

        public byte[]? ProfilePicture { get; set; }
    }
}
