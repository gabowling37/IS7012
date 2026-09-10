namespace RecruitCatBowlingy.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionRecruiting { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public DateOnly? StartDate { get; set; }
        public string Location { get; set; }
        public int NumberOfEmployees { get; set; }
        public int? YearFounded { get; set; }

        // Relationships
        public List<Candidate>? Candidates { get; set; }
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
    }
}
