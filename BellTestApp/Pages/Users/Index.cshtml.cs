using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BellTestApp.Models;

namespace BellTestApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly BellTestApp.Data.BellTestAppContext _context;

        public IndexModel(BellTestApp.Data.BellTestAppContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User.ToListAsync();
            }
        }
    }
}
