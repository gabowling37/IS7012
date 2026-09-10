namespace RecruitCatBowlingy.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationships
        public List<Company>? Companies { get; set; }
        public List<Candidate>? Candidates { get; set; }
    }
}
