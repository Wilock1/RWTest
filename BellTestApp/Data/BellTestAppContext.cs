using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BellTestApp.Models;

namespace BellTestApp.Data
{
    public class BellTestAppContext : DbContext
    {
        public BellTestAppContext (DbContextOptions<BellTestAppContext> options)
            : base(options)
        {
        }

        public DbSet<BellTestApp.Models.User> User { get; set; } = default!;
    }
}
