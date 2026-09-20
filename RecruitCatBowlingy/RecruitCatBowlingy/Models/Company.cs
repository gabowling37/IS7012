using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatBowlingy.Models
{
    public class Company
    {
        [DisplayName("Company")]
        public int Id { get; set; }

        [DisplayName("Company Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "Company Name is required.")]
        public string Name { get; set; }

        [DisplayName("Position Recruiting For")]
        [StringLength(100)]
        [Required(ErrorMessage = "Position Recruiting For is required.")]
        public string PositionRecruiting { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(typeof(decimal), "0", "10000000", ErrorMessage = "Salary must be between {1} and {2}.")]
        [Required(ErrorMessage = "Minimum Salary is required.")]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(typeof(decimal), "0", "10000000", ErrorMessage = "Salary must be between {1} and {2}.")]
        [Required(ErrorMessage = "Maximum Salary is required.")]
        public decimal MaximumSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [StringLength(300)]
        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [DisplayName("Number of Employees")]
        [Range(0, 1000000, ErrorMessage = "Number of Employees must be between {1} and {2}.")]
        [Required(ErrorMessage = "Number of Employees is required.")]
        public int NumberOfEmployees { get; set; }

        [DisplayName("Year Founded")]
        [Range(1000, 10000, ErrorMessage = "Year Founded must be between {1} and {2}.")]
        [Required(ErrorMessage = "Year Founded is required.")]
        public int? YearFounded { get; set; }

        // Relationships
        public List<Candidate>? Candidates { get; set; }

        [DisplayName("Industry")]
        [Required(ErrorMessage = "Industry is required.")]
        public int IndustryId { get; set; }

        [ValidateNever]
        public Industry Industry { get; set; }
    }
}
