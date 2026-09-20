using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.IndustryPages;

public class IndexModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;

    public IndexModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public IList<Industry> Industry { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Industry = await _context.Industry.ToListAsync();
    }
}
