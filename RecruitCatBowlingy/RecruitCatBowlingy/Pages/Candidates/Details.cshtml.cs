using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.CandidatePages;

public class DetailsModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;
    public DetailsModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public Candidate Candidate { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var candidate = await _context.Candidate
            .Include(c => c.Company)
            .Include(c => c.JobTitle)
            .Include(c => c.Industry)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (candidate is null)
        {
            return NotFound();
        }
        else
        {
            Candidate = candidate;
        }

        return Page();
    }
}
