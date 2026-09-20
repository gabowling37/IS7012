using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatBowlingy.Models
{
    public class JobTitle
    {
        [DisplayName("Job Title")]
        public int Id { get; set; }

        [DisplayName("Job Title")]
        [StringLength(100)]
        [Required(ErrorMessage = "Job Title is required.")]
        public string Title { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(typeof(decimal), "0", "10000000", ErrorMessage = "Salary must be between {1} and {2}.")]
        [Required(ErrorMessage = "Minimum Salary is required.")]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(typeof(decimal), "0", "10000000", ErrorMessage = "Salary must be between {1} and {2}.")]
        [Required(ErrorMessage = "Maximum Salary is required.")]
        public decimal MaximumSalary { get; set; }

        [DisplayName("Can Supervise Staff")]
        public bool CanSuperviseStaff { get; set; }

        // Relationships
        public List<Candidate>? Candidates { get; set; }
    }
}
