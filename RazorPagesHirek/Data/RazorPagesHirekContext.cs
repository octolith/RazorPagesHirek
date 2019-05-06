using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesHirek.Models
{
    public class RazorPagesHirekContext : DbContext
    {
        public RazorPagesHirekContext (DbContextOptions<RazorPagesHirekContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesHirek.Models.Article> Article { get; set; }
    }
}
