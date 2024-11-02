using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.PayMode
{
    public class DeleteModel : PageModel
    {
        private readonly SumpermarketContext _context;

        public DeleteModel(SumpermarketContext context)
        {
            _context = context;
        }

        [BindProperty]

        public PayModes PayModes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.payModes == null)
            {
                return NotFound();
            }

            var category = await _context.payModes.FirstOrDefaultAsync(m => m.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            else
            {
                PayModes = PayModes;
            }

            return Page();

        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.payModes == null)
            {
                return NotFound();
            }

           

            if (PayModes != null)
            {
                PayModes = PayModes;
                _context.payModes.RemoveRange();
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

    }
}

