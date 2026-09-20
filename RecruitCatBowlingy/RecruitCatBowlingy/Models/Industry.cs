using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatBowlingy.Models
{
    public class Industry
    {
        [DisplayName("Industry")]
        public int Id { get; set; }

        [DisplayName("Industry Name")]
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Industry Name is required.")]
        public string Name { get; set; }

        // Relationships
        public List<Company>? Companies { get; set; }
        public List<Candidate>? Candidates { get; set; }
    }
}
