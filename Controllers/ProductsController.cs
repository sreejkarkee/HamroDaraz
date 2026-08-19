using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HamroDaraz.Data;

namespace HamroDaraz.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Products
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Include(p => p.Category).ToListAsync();
            return View(products);
        }
    }
}