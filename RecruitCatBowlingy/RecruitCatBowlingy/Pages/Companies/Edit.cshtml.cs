using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.CompanyPages;

public class EditModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;

    public EditModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Company Company { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var company = await _context.Company.FirstOrDefaultAsync(m => m.Id == id);
        if (company is null)
        {
            return NotFound();
        }
        Company = company;
        ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name");
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Company).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CompanyExists(Company.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool CompanyExists(int id)
    {
        return _context.Company.Any(e => e.Id == id);
    }
}
