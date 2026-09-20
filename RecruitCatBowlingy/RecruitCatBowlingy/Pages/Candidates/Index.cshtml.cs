using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.CandidatePages;

public class IndexModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;

    public IndexModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public IList<Candidate> Candidate { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Candidate = await _context.Candidate
            .Include(c => c.Company)
            .Include(c => c.JobTitle)
            .Include(c => c.Industry)
            .ToListAsync();
    }
}
