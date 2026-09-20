using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatBowlingy.Models
{
    public class Candidate
    {
        [DisplayName("Candidate")]
        public int Id { get; set; }

        [DisplayName("First Name")]
        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(50, MinimumLength = 1)]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [DisplayName("Candidate Name")]
        [StringLength(101, MinimumLength = 2)]
        public string FullName => $"{FirstName} {LastName}";

        [DisplayName("Target Salary")]
        [Range(typeof(decimal), "0", "10000000", ErrorMessage = "Salary must be between {1} and {2}.")]
        [Required(ErrorMessage = "Target Salary is required.")]
        public decimal TargetSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [StringLength(254)]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is required.")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Level of Education")]
        [StringLength(50, MinimumLength = 2)]
        [Required(ErrorMessage = "Level of Education is required.")]
        public string LevelOfEducation { get; set; }

        // Relationships
        [DisplayName("Company")]
        public int? CompanyId { get; set; }

        public Company? Company { get; set; }

        [DisplayName("Job Title")]
        [Required(ErrorMessage = "Job Title is required.")]
        public int JobTitleId { get; set; }

        [DisplayName("Job Title")]
        [ValidateNever]
        public JobTitle JobTitle { get; set; }

        [DisplayName("Industry")]
        public int? IndustryId { get; set; }

        public Industry? Industry { get; set; }
    }
}
