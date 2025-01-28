using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesLogin.Models;

namespace RazorPagesLogin.Data
{
    public class RazorPagesLoginContext : DbContext
    {
        public RazorPagesLoginContext (DbContextOptions<RazorPagesLoginContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesLogin.Models.User> User { get; set; } = default!;
    }
}
