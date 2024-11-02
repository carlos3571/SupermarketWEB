using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;
using SupermarketWEB.Data;

namespace SupermarketWEB.Pages.PayMode
{
    public class IndexModel : PageModel
    {
        private readonly SumpermarketContext _context;
        public IndexModel(SumpermarketContext context)
        {
            _context = context;
        }
        public IList<PayModes> payModes { get; set; } = default!;
        //public IList<Category> Categories { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                payModes = await _context.payModes.ToListAsync();
            }
        }
    }
}

