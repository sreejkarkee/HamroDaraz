using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HamroDaraz.Data;
using HamroDaraz.Models;

namespace HamroDaraz.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.Category)
                .ToListAsync();
        }
    }
}
