using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BetterQueue.Data;
using BetterQueue.Models;

namespace BetterQueue.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Location> Locations { get; set; } = new();

        public async Task OnGetAsync()
        {
            Locations = await _context.Locations.Where(l => l.IsActive).ToListAsync();
        }
    }
}
