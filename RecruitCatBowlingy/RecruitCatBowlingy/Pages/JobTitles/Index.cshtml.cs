using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.JobTitlePages;

public class IndexModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;

    public IndexModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public IList<JobTitle> JobTitle { get; set; } = default!;

    public async Task OnGetAsync()
    {
        JobTitle = await _context.JobTitle.ToListAsync();
    }
}
