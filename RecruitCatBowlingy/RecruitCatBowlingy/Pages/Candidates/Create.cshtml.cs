using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.CandidatePages;

public class CreateModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;

    public CreateModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Name");
        ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "Id", "Title");
        return Page();
    }

    [BindProperty]
    public Candidate Candidate { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Candidate.Add(Candidate);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
