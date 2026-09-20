using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.JobTitlePages;

public class DetailsModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;
    public DetailsModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public JobTitle JobTitle { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var jobtitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.Id == id);
        if (jobtitle is null)
        {
            return NotFound();
        }
        else
        {
            JobTitle = jobtitle;
        }

        return Page();
    }
}
