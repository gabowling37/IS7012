using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.CompanyPages;

public class DetailsModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;
    public DetailsModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public Company Company { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var company = await _context.Company
            .Include(c => c.Industry)
            .Include(c => c.Candidates)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (company is null)
        {
            return NotFound();
        }
        else
        {
            Company = company;
        }

        return Page();
    }
}
