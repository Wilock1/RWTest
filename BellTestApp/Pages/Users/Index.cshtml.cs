using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BellTestApp.Models;

namespace BellTestApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly BellTestApp.Data.BellTestAppContext _context;
        public String genericMessage = string.Empty;

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

            if (Request.Query["handler"].ToString() == "s")
            {
                genericMessage = "User Added";
            }
            else if (Request.Query["handler"].ToString() == "d")
            {
                genericMessage = "User Deleted";
            }
            else if (Request.Query["handler"].ToString() == "e")
            {
                genericMessage = "User Updated";
            }
        }
    }
}
