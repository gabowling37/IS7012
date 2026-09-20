using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatBowlingy.Models;

namespace RecruitCatBowlingy.Pages.CandidatePages;

public class EditModel : PageModel
{
    private readonly RecruitCatBowlingyContext _context;

    public EditModel(RecruitCatBowlingyContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Candidate Candidate { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var candidate = await _context.Candidate.FirstOrDefaultAsync(m => m.Id == id);
        if (candidate is null)
        {
            return NotFound();
        }
        Candidate = candidate;
        ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Name");
        ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "Id", "Title");
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

        _context.Attach(Candidate).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CandidateExists(Candidate.Id))
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

    private bool CandidateExists(int id)
    {
        return _context.Candidate.Any(e => e.Id == id);
    }
}
