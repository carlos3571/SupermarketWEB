using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Providers
{
    public class DeleteModel : PageModel
    {

            private readonly SumpermarketContext _context;

            public DeleteModel(SumpermarketContext context)
            {
                _context = context;
            }

            [BindProperty]

            public Provider Provider { get; set; } = default!;

            public async Task<IActionResult> OnGetAsync(int? id)
            {
                if (id == null || _context.providers == null)
                {
                    return NotFound();
                }

                var Provider = await _context.providers.FirstOrDefaultAsync(m => m.Id == id);

                if (Provider == null)
                {
                    return NotFound();
                }

                else
                {
                Provider = Provider;
                }

                return Page();

            }

            public async Task<IActionResult> OnPostAsync(int? id)
            {
                if (id == null || _context.providers == null)
                {
                    return NotFound();
                }

                var Provider = await _context.providers.FindAsync(id);

                if (Provider != null)
                {
                Provider = Provider;
                    _context.providers.Remove(Provider);
                    await _context.SaveChangesAsync();
                }

                return RedirectToPage("./Index");
            }

        }
    }
