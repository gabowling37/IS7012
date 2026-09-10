namespace RecruitCatBowlingy.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateOnly? StartDate { get; set; }
        public string Email { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string LevelOfEducation { get; set; }

        // Relationships
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int? IndustryId { get; set; }
        public Industry? Industry { get; set; }
    }
}
