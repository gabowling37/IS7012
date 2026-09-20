using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.CompanyPages;

public class IndexModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;

    public IndexModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public IList<Company> Company { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Company = await _context.Company
            .Include(c => c.Industry)
            .ToListAsync();
    }
}
