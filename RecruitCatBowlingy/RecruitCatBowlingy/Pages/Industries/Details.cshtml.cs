using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.IndustryPages;

public class DetailsModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;
    public DetailsModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public Industry Industry { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var industry = await _context.Industry.FirstOrDefaultAsync(m => m.Id == id);
        if (industry is null)
        {
            return NotFound();
        }
        else
        {
            Industry = industry;
        }

        return Page();
    }
}
