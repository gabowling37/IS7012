using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.CompanyPages;

public class CreateModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;

    public CreateModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name");
        return Page();
    }

    [BindProperty]
    public Company Company { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Company.Add(Company);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
