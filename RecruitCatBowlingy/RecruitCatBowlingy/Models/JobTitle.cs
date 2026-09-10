namespace RecruitCatBowlingy.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public bool CanSuperviseStaff { get; set; }

        // Relationships
        public List<Candidate>? Candidates { get; set; }
    }
}
