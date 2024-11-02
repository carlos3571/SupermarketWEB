using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.PayMode
{
    public class CreateModel : PageModel
    {
        private readonly SumpermarketContext _context;
        public CreateModel(SumpermarketContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]

        public PayModes PayModes { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.payModes == null || PayModes == null)
            {
                return Page();
            }
            _context.payModes.Add(PayModes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}