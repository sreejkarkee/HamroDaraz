using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HamroDaraz.Data;
using HamroDaraz.Models;

namespace HamroDaraz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Products = await _context.Products
                .Include(p => p.Category)
                .ToListAsync();
        }
    }
}